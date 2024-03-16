using Microsoft.JSInterop;
using Portal.Patient.Constants;
using Portal.Patient.Interfaces;
using Portal.Patient.Models;
using Portal.Patient.Services;

namespace Portal.Patient.Repositories
{
    public class NotificationService : INotificationService
    {
        private readonly IJSRuntime _JSRuntime;

        public NotificationService(IJSRuntime JSRuntime)
        {
            _JSRuntime = JSRuntime;
        }

        public IEnumerable<INotification> GetForCurrentUser()
        {
            //TODO: pull from API

            return new List<Notification>() {
                new Notification { 
                    NotificationTypeID = (int)NotificationTypeID.RecommendedIntervention, 
                    Message = "You have new recommended interventions. Click here to view more information." 
                }
            };
        }

        public async Task Subscribe()
        {
            var subscription = await _JSRuntime.InvokeAsync<NotificationSubscription>("blazorPushNotifications.requestSubscription");


            if(subscription is not null)
            {
                // TODO store this user id.
                subscription.UserId = Guid.NewGuid().ToString();

                // TODO send subscription to server. 
            }
        }
    }
}
