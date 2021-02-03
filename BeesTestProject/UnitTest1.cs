using NUnit.Framework;
using Bees;

namespace BeesTestProject
{
    public class Tests
    {
        
        [Test]
        public void DamageMethodTest1()
        {
            //This test is to check if the damage method works when health is at maximum health.
            Bee bee1 = new Bee();
            bee1.Damage(5);
            Assert.AreEqual(95,bee1.Health);
        }
        [Test]
        public void DamageMethodTest2()
        {
            //This test is to check if the damage method works when health is not at maximum health.
            Bee bee1 = new Bee();
            bee1.Damage(5);
            bee1.Damage(5);
            Assert.AreEqual(90.25, bee1.Health);
        }
        [Test]
        public void DamageMethodTest3()
        {
            //This test is to check if the damage method doesn't cause an error when damageDealt input is too low.
            Bee bee1 = new Bee();
            bee1.Damage(0);
            Assert.AreEqual(100, bee1.Health);
        }
        [Test]
        public void DamageMethodTest4()
        {
            //This test is to check if the damage method doesn't cause an error when damageDealt input is too high.
            Bee bee1 = new Bee();
            bee1.Damage(101);
            Assert.AreEqual(100, bee1.Health);
        }
        [Test]
        public void DroneAliveTest()
        {
            //This test is to check if the drone is still alive after 10 damage.
            DroneBee bee1 = new DroneBee();
            bee1.Damage(10);
            Assert.AreEqual(false, bee1.IsDead);
        }
        [Test]
        public void DroneDeadTest()
        {
            ///This test is to check if the drone is not still alive after 60 damage.
            DroneBee bee1 = new DroneBee();
            bee1.Damage(60);
            Assert.AreEqual(true, bee1.IsDead);
        }
        [Test]
        public void WorkerAliveTest()
        {
            //This test is to check if the worker is still alive after 10 damage.
            WorkerBee bee1 = new WorkerBee();
            bee1.Damage(10);
            Assert.AreEqual(false, bee1.IsDead);
        }
        [Test]
        public void WorkerDeadTest()
        {
            ///This test is to check if the worker is not still alive after 40 damage.
            WorkerBee bee1 = new WorkerBee();
            bee1.Damage(40);
            Assert.AreEqual(true, bee1.IsDead);
        }
        [Test]
        public void QueenAliveTest()
        {
            //This test is to check if the queen is still alive after 10 damage.
            QueenBee bee1 = new QueenBee();
            bee1.Damage(10);
            Assert.AreEqual(false, bee1.IsDead);
        }
        [Test]
        public void QueenDeadTest()
        {
            ///This test is to check if the queen is not still alive after 90 damage.
            QueenBee bee1 = new QueenBee();
            bee1.Damage(90);
            Assert.AreEqual(true, bee1.IsDead);
        }
    }
}