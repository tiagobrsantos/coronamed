using CoronaMed.Model;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using System.Net.Http;
using Newtonsoft.Json;

namespace CoronaMed.IntegrationTest
{
	public class ContactUsIntegrationTest : IntegrationTest
	{
		[Fact]
		public async Task CreateContactUs_Ok()
		{
			ContactUs contactUs = TestDataFactory.GetContactUs();

			var response = await httpTestClient.PostAsJsonAsync("/api/contactUs", contactUs);
			Assert.True(response.StatusCode == HttpStatusCode.OK);
		}

		[Fact]
		public async Task CreateContactUs_InvalidEmail_Fail()
		{
			ContactUs contactUs = TestDataFactory.GetContactUs();
			contactUs.Email = string.Empty;

			var response = await httpTestClient.PostAsJsonAsync("/api/contactUs", contactUs);
			Assert.True(response.StatusCode == HttpStatusCode.BadRequest);
		}

		[Fact]
		public async Task CreateContactUs_InvalidMessage_Fail()
		{
			ContactUs contactUs = TestDataFactory.GetContactUs();
			contactUs.Message = string.Empty;

			var response = await httpTestClient.PostAsJsonAsync("/api/contactUs", contactUs);
			Assert.True(response.StatusCode == HttpStatusCode.BadRequest);
		}

		[Fact]
		public async Task CreateContactUs_InvalidId_Fail()
		{
			ContactUs contactUs = TestDataFactory.GetContactUs();
			contactUs.Id = 1;

			var response = await httpTestClient.PostAsJsonAsync("/api/contactUs", contactUs);
			Assert.True(response.StatusCode == HttpStatusCode.BadRequest);
		}

		[Fact]
		public async Task UpdateContactUs_Ok()
		{
			ContactUs contactUs = TestDataFactory.GetContactUs();

			var response = await httpTestClient.PostAsJsonAsync("/api/contactUs", contactUs);
			if (response.IsSuccessStatusCode)
			{
				contactUs = JsonConvert.DeserializeObject<ContactUs>(await response.Content.ReadAsStringAsync());

				response = await httpTestClient.PutAsJsonAsync("/api/contactUs", contactUs);

				Assert.True(response.StatusCode == HttpStatusCode.OK);
			}						
		}

		[Fact]
		public async Task UpdateContactUs_InvalidEmail_Fail()
		{
			ContactUs contactUs = TestDataFactory.GetContactUs();

			var response = await httpTestClient.PostAsJsonAsync("/api/contactUs", contactUs);
			if (response.IsSuccessStatusCode)
			{
				contactUs = JsonConvert.DeserializeObject<ContactUs>(await response.Content.ReadAsStringAsync());
				contactUs.Email = string.Empty;

				response = await httpTestClient.PutAsJsonAsync("/api/contactUs", contactUs);

				Assert.True(response.StatusCode == HttpStatusCode.BadRequest);
			}
		}

		[Fact]
		public async Task UpdateContactUs_InvalidMessage_Fail()
		{
			ContactUs contactUs = TestDataFactory.GetContactUs();

			var response = await httpTestClient.PostAsJsonAsync("/api/contactUs", contactUs);
			if (response.IsSuccessStatusCode)
			{
				contactUs = JsonConvert.DeserializeObject<ContactUs>(await response.Content.ReadAsStringAsync());
				contactUs.Email = string.Empty;

				response = await httpTestClient.PutAsJsonAsync("/api/contactUs", contactUs);

				Assert.True(response.StatusCode == HttpStatusCode.BadRequest);
			}
		}

		[Fact]
		public async Task UpdateContactUs_InvalidId_Fail()
		{
			ContactUs contactUs = TestDataFactory.GetContactUs();

			var response = await httpTestClient.PostAsJsonAsync("/api/contactUs", contactUs);
			if (response.IsSuccessStatusCode)
			{
				contactUs = JsonConvert.DeserializeObject<ContactUs>(await response.Content.ReadAsStringAsync());
				contactUs.Id = 0;

				response = await httpTestClient.PutAsJsonAsync("/api/contactUs", contactUs);

				Assert.True(response.StatusCode == HttpStatusCode.BadRequest);
			}
		}

		[Fact]
		public async Task DeleteContactUs_Ok()
		{
			ContactUs contactUs = TestDataFactory.GetContactUs();

			var response = await httpTestClient.PostAsJsonAsync("/api/contactUs", contactUs);
			if (response.IsSuccessStatusCode)
			{
				contactUs = JsonConvert.DeserializeObject<ContactUs>(await response.Content.ReadAsStringAsync());
				//contactUs.Id = 0;

				response = await httpTestClient.DeleteAsync("/api/contactUs/" + contactUs.Id);

				Assert.True(response.StatusCode == HttpStatusCode.OK);
			}
		}

		[Fact]
		public async Task DeleteContactUs_InvalidId_Fail()
		{
			ContactUs contactUs = TestDataFactory.GetContactUs();

			var response = await httpTestClient.PostAsJsonAsync("/api/contactUs", contactUs);
			if (response.IsSuccessStatusCode)
			{
				contactUs = JsonConvert.DeserializeObject<ContactUs>(await response.Content.ReadAsStringAsync());
				contactUs.Id = 100;

				response = await httpTestClient.DeleteAsync("/api/contactUs/" + contactUs.Id);

				Assert.True(response.StatusCode == HttpStatusCode.BadRequest);
			}
		}
	}
}
