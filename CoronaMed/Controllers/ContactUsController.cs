using System.Threading.Tasks;
using CoronaMed.Command;
using CoronaMed.Commands;
using CoronaMed.Commands.Handlers.Interface;
using CoronaMed.Helper;
using CoronaMed.Model;
using CoronaMed.Model.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CoronaMed.Controllers
{
	[Route("api/contactus")]
	[ApiController]
	public class ContactUsController : ControllerBase
	{

		private readonly IContactUsCommandHandler partnerCommandHandler;
		private readonly IContactUsRepository partnerRepository;
		public ContactUsController(IContactUsCommandHandler partnerCommandHandler, IContactUsRepository partnerRepository)
		{
			this.partnerCommandHandler = partnerCommandHandler;
			this.partnerRepository = partnerRepository;
		}

		[HttpGet("{id:int}")]
		public async Task<IActionResult> Get(int id)
		{
			return Ok(partnerRepository.Get(x => x.Id == id));
		}

		[HttpPost]
		public async Task<IActionResult> Post([FromBody] ContactUs partner)
		{
			CreateContactUsCommand command = new CreateContactUsCommand(partner);

			await partnerCommandHandler.ExecuteAsync(command);
			
			return this.HandleNotification(partnerCommandHandler, partner);
		}

		[HttpPut]
		public async Task<IActionResult> Put([FromBody] ContactUs partner)
		{
			UpdateContactUsCommand command = new UpdateContactUsCommand(partner);

			await partnerCommandHandler.ExecuteAsync(command);			

			return this.HandleNotification(partnerCommandHandler, partner);

		}

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Delete(int id)
		{
			DeleteEntityCommand command = new DeleteEntityCommand(id);
			await partnerCommandHandler.ExecuteAsync(command);			

			return this.HandleNotification(partnerCommandHandler);
		}
	}
}