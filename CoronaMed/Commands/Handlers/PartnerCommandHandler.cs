using CoronaMed.Command;
using CoronaMed.Commands.Handlers.Interface;
using CoronaMed.Helper;
using CoronaMed.Model.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Commands.Handlers
{
	public class PartnerCommandHandler : Notifiable, IPartnerCommandHandler
	{
		private readonly ILogger logger;
		private readonly IPartnerRepository partnerRepository;

		public PartnerCommandHandler(IPartnerRepository partnerRepository, ILogger<PartnerCommandHandler> logger)
		{
			this.partnerRepository = partnerRepository;
			this.logger = logger;
		}

		public async Task ExecuteAsync(CreatePartnerCommand command)
		{
			if (!command.Validate())
			{
				AddNotification(command.GetNotifications());
				return;
			}

			try
			{
				await partnerRepository.AddAsync(command.Partner);
			}
			catch (Exception ex)
			{
				logger.LogError(ex.Message, ex);
				AddNotification(ex.Message, System.Net.HttpStatusCode.InternalServerError);
			}

		}

		[HttpPut]
		public async Task ExecuteAsync(UpdatePartnerCommand command)
		{
			if (!command.Validate())
			{
				AddNotification(command.GetNotifications());
				return;
			}

			AddNotification(!partnerRepository.Get().Any(x => x.Id == command.Partner.Id), "Partner Id Not Found");
			
			if (!IsValid)
				return;


			try
			{
				await partnerRepository.UpdateAsync(command.Partner);
			}
			catch (Exception ex)
			{
				logger.LogError(ex.Message, ex);
				AddNotification(ex.Message, System.Net.HttpStatusCode.InternalServerError);
			}
		}

		public async Task ExecuteAsync(DeleteEntityCommand command)
		{
			if (!command.Validate())
			{
				AddNotification(command.GetNotifications());
				return;
			}

			AddNotification(partnerRepository.Get().Any(x => x.Id == command.Id), "Partner Id Not Found");

			if (!IsValid)
				return;

			try
			{
				await partnerRepository.DeleteAsync(partnerRepository.Get(x => x.Id == command.Id).FirstOrDefault());
			}
			catch (Exception ex)
			{
				logger.LogError(ex.Message, ex);
				AddNotification(ex.Message, System.Net.HttpStatusCode.InternalServerError);
			}
		}
	}
}
