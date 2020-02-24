using NUnit.Framework;
using NSubstitute;
using FlowerShop;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckDeliveries()
        {
            //ARRANGE
            IClient newClient = Substitute.For<IClient>();
            IOrderDAO newOrderDAO = Substitute.For<IOrderDAO>();
            Order one = new Order (newOrderDAO, newClient);

            //ACT 
            one.Deliver();

            //ASSERT
            newOrderDAO.Received().SetDelivered(one);
        
        }
    }
}