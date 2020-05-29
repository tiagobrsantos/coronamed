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
	[Route("api/partners")]
	[ApiController]
	public class PartnerController : ControllerBase
	{

		private readonly IPartnerCommandHandler partnerCommandHandler;
		private readonly IPartnerRepository partnerRepository;
		public PartnerController(IPartnerCommandHandler partnerCommandHandler, IPartnerRepository partnerRepository)
		{
			this.partnerCommandHandler = partnerCommandHandler;
			this.partnerRepository = partnerRepository;
		}

		[HttpGet("{id:int}")]
		public async Task<IActionResult> Get(int id)
		{
			return Ok(partnerRepository.Get());
		}

		[HttpPost]
		public async Task<IActionResult> Post([FromBody] Partner partner)
		{
			CreatePartnerCommand command = new CreatePartnerCommand(partner);

			await partnerCommandHandler.ExecuteAsync(command);
			
			return this.HandleNotification(partnerCommandHandler, partner);
		}

		[HttpPut]
		public async Task<IActionResult> Put([FromBody] Partner partner)
		{
			UpdatePartnerCommand command = new UpdatePartnerCommand(partner);

			await partnerCommandHandler.ExecuteAsync(command);			

			return this.HandleNotification(partnerCommandHandler, partner);

		}

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Delete(int id)
		{
			DeleteEntityCommand command = new DeleteEntityCommand(id);
			await partnerCommandHandler.ExecuteAsync(command);			

			return this.HandleNotification(partnerCommandHandler, null);
		}
	}
}