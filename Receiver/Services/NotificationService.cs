using Grpc.Core;
using GrpcApp;
using System.Threading.Tasks;
using System;

namespace Receiver.Services
{
    public class NotificationService : Notifier.NotifierBase
    {
        public override Task<NotifyReply> Notify(NotifyRequest notify, ServerCallContext callContext)
        {
           
            return Task.FromResult(new NotifyReply()
            {
                IsSuccess = true,
            });
        }
    }
}
