using CoronaMed.Model;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using System.Net.Http;
using Newtonsoft.Json;

namespace CoronaMed.IntegrationTest
{
	public class PartnerIntegrationTest : IntegrationTest
	{
		[Fact]
		public async Task CreatePartner_Ok()
		{
			Partner partner = TestDataFactory.GetPartner();

			var response = await httpTestClient.PostAsJsonAsync("/api/partners", partner);
			Assert.True(response.StatusCode == HttpStatusCode.OK);
		}

		[Fact]
		public async Task CreatePartner_InvalidName_Fail()
		{
			Partner partner = TestDataFactory.GetPartner();
			partner.Name = string.Empty;

			var response = await httpTestClient.PostAsJsonAsync("/api/partners", partner);
			Assert.True(response.StatusCode == HttpStatusCode.BadRequest);
		}

		[Fact]
		public async Task UpdatePartner_Ok()
		{
			Partner partner = TestDataFactory.GetPartner();

			var response = await httpTestClient.PostAsJsonAsync("/api/partners", partner);
			if (response.IsSuccessStatusCode)
			{
				partner = JsonConvert.DeserializeObject<Partner>(await response.Content.ReadAsStringAsync());

				response = await httpTestClient.PutAsJsonAsync("/api/partners", partner);

				Assert.True(response.StatusCode == HttpStatusCode.OK);
			}						
		}

		[Fact]
		public async Task UpdatePartner_InvalidName_Fail()
		{
			Partner partner = TestDataFactory.GetPartner();

			var response = await httpTestClient.PostAsJsonAsync("/api/partners", partner);
			if (response.IsSuccessStatusCode)
			{
				partner = JsonConvert.DeserializeObject<Partner>(await response.Content.ReadAsStringAsync());
				partner.Name = string.Empty;

				response = await httpTestClient.PutAsJsonAsync("/api/partners", partner);

				Assert.True(response.StatusCode == HttpStatusCode.BadRequest);
			}
		}

		[Fact]
		public async Task UpdatePartner_InvalidId_Fail()
		{
			Partner partner = TestDataFactory.GetPartner();

			var response = await httpTestClient.PostAsJsonAsync("/api/partners", partner);
			if (response.IsSuccessStatusCode)
			{
				partner = JsonConvert.DeserializeObject<Partner>(await response.Content.ReadAsStringAsync());
				partner.Id = 0;

				response = await httpTestClient.PutAsJsonAsync("/api/partners", partner);

				Assert.True(response.StatusCode == HttpStatusCode.BadRequest);
			}
		}

		[Fact]
		public async Task DeletePartner_Ok()
		{
			Partner partner = TestDataFactory.GetPartner();

			var response = await httpTestClient.PostAsJsonAsync("/api/partners", partner);
			if (response.IsSuccessStatusCode)
			{
				partner = JsonConvert.DeserializeObject<Partner>(await response.Content.ReadAsStringAsync());
				partner.Id = 0;

				response = await httpTestClient.DeleteAsync("/api/partners/" + partner.Id);

				Assert.True(response.StatusCode == HttpStatusCode.OK);
			}
		}
	}
}
