

using GameHomework.Entities;

namespace GameHomework.Abstract
{
    public interface IOrderService
    {
        void Order(User gamer,Game game, Campaign campaign);
    }
}
