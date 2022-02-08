using System.Collections.Generic;
using MatData;

namespace Matdata.API.Services.Message
{
    public interface IMessageService
	{
		List<Models.Message>GetMessages();
		Models.Message GetMessageById(int id);
		ServiceResponse<bool> DeleteMessage(int id);
		ServiceResponse<bool> CreateMessage(Models.Message message);
	}
}

