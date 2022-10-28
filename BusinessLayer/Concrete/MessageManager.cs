using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageserviceDal;

        public MessageManager(IMessageDal messageserviceDal)
        {
            _messageserviceDal = messageserviceDal;
        }

        public Message GetByID(int id)
        {
            return _messageserviceDal.Get(x=>x.MessageID==id);
        }

        public List<Message> GetListInbox()
        {
            return _messageserviceDal.List(x=>x.ReceiverMail=="admin@gmail.com");
        }

        public List<Message> GetListSendBox()
        {
            return _messageserviceDal.List(x => x.SenderMail == "admin@gmail.com");
        }

        public void MessageAdd(Message message)
        {
            _messageserviceDal.Add(message);
        }

        public void MessageDelete(Message message)
        {
            _messageserviceDal.Delete(message);
        }

        public void MessageUpdate(Message message)
        {
            _messageserviceDal.Add(message);
        }
    }
}
