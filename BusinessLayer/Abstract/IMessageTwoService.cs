using System;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageTwoService : IGenericService<MessageTwo>
    {
        List<MessageTwo> GetInboxListByWriter(int id);

    }
}
