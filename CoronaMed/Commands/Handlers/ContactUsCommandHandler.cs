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
	public class ContactUsCommandHandler : Notifiable, IContactUsCommandHandler
	{
		private readonly ILogger logger;
		private readonly IContactUsRepository contactUsRepository;

		public ContactUsCommandHandler(IContactUsRepository contactUsRepository, ILogger<ContactUsCommandHandler> logger)
		{
			this.contactUsRepository = contactUsRepository;
			this.logger = logger;
		}

		public async Task ExecuteAsync(CreateContactUsCommand command)
		{
			if (!command.Validate())
			{
				AddNotification(command.GetNotifications());
				return;
			}

			try
			{
				await contactUsRepository.AddAsync(command.ContactUs);
			}
			catch (Exception ex)
			{
				logger.LogError(ex.Message, ex);
				AddNotification(ex.Message, System.Net.HttpStatusCode.InternalServerError);
			}

		}

		[HttpPut]
		public async Task ExecuteAsync(UpdateContactUsCommand command)
		{
			if (!command.Validate())
			{
				AddNotification(command.GetNotifications());
				return;
			}

			AddNotification(!contactUsRepository.Get().Any(x => x.Id == command.ContactUs.Id), "ContactUs Id Not Found");
			
			if (!IsValid)
				return;


			try
			{
				await contactUsRepository.UpdateAsync(command.ContactUs);
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

			AddNotification(!contactUsRepository.Get().Any(x => x.Id == command.Id), "ContactUs Id Not Found");

			if (!IsValid)
				return;

			try
			{
				await contactUsRepository.DeleteAsync(contactUsRepository.Get(x => x.Id == command.Id).FirstOrDefault());
			}
			catch (Exception ex)
			{
				logger.LogError(ex.Message, ex);
				AddNotification(ex.Message, System.Net.HttpStatusCode.InternalServerError);
			}
		}
	}
}
