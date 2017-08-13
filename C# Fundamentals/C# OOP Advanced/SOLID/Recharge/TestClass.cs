using NUnit.Framework;

namespace Recharge
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void EmployeeWorkTest()
        {
            ISleeper worker = new Employee("1");

            worker.Work(10);

            Assert.AreEqual(10, worker.WorkingHours);
        }

        [Test]
        public void RobotWorkTest()
        {
            IRechargeable worker = new Robot("1", 10);

            worker.Work(10);

            Assert.AreEqual(0, worker.CurrentPower);
        }

        [Test]
        public void RebotCapacityDepleting()
        {
            IRechargeable worker = new Robot("1", 10);

            worker.Work(10);

            Assert.AreEqual(0, worker.CurrentPower);
        }

        [Test]
        public void RobotCapacity()
        {
            IRechargeable worker = new Robot("1", 10);

            Assert.AreEqual(10, worker.Capacity);
        }

        [Test]
        public void RobotRecharging()
        {
            IRechargeable worker = new Robot("1", 10);

            worker.Work(10);
            worker.Recharge();

            Assert.AreEqual(10, worker.CurrentPower);
        }
    }
}