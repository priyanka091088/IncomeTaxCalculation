using Microsoft.VisualStudio.TestTools.UnitTesting;
using IncomeTaxCalculation;
namespace IncomeTaxTest
{
    [TestClass]
    public class UnitTest1
    {
        double actual = 0;
        [TestMethod]
        public void when_Age_LessThanEqualToZero()
        { 
          //when age <=0
            TaxCalculator ageLessThan0 = new TaxCalculator(-9, 600000); //age<0
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => ageLessThan0.IsAgeValid(-9));

            TaxCalculator ageEqualTo0 = new TaxCalculator(0, 600000); //age=0
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => ageEqualTo0.IsAgeValid(0));
        }

            [TestMethod]
            public void when_Age_LessThanSixty()
            {
            //when age(<60) 
                TaxCalculator salaryLessThan0 = new TaxCalculator(21, -980); //salary<0
                Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => salaryLessThan0.IsSalaryValid(-980));

                TaxCalculator salaryEqualTo0 = new TaxCalculator(21, 0); //salary=0
                Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => salaryEqualTo0.IsSalaryValid(0));

                TaxCalculator salaryLessThan_TwoPointFive = new TaxCalculator(21, 200000); //salary<2.5LPA
                actual = salaryLessThan_TwoPointFive.CalculateTax();
                Assert.AreEqual(0, actual, 0.001, "salary not calculated correctly");

                TaxCalculator salaryEqualTo_TwoPointFive = new TaxCalculator(21, 250000); //salary=2.5LPA
                actual = salaryEqualTo_TwoPointFive.CalculateTax();
                Assert.AreEqual(0, actual, 0.001, "salary not calculated correctly");

                TaxCalculator salaryGreaterThan_TwoPointFive = new TaxCalculator(21, 285000); //salary>2.5LPA
                actual = salaryGreaterThan_TwoPointFive.CalculateTax();
                Assert.AreEqual(14250, actual, 0.001, "salary not calculated correctly");

                TaxCalculator salaryEqualTo_Five = new TaxCalculator(21, 500000); //salary=5LPA
                actual = salaryEqualTo_Five.CalculateTax();
                Assert.AreEqual(25000, actual, 0.001, "salary not calculated correctly");

                TaxCalculator salaryGreaterThan_Five = new TaxCalculator(21, 575000); //salary>5LPA
                actual = salaryGreaterThan_Five.CalculateTax();
                Assert.AreEqual(27500, actual, 0.001, "salary not calculated correctly");

                TaxCalculator salaryEqualTo_Ten = new TaxCalculator(21, 1000000); //salary=10LPA
                actual = salaryEqualTo_Ten.CalculateTax();
                Assert.AreEqual(112500, actual, 0.001, "salary not calculated correctly");

                TaxCalculator salaryGreaterThan_Ten = new TaxCalculator(21, 2000000); //salary>10LPA
                actual = salaryGreaterThan_Ten.CalculateTax();
                Assert.AreEqual(412500, actual, 0.001, "salary not calculated correctly");
            }
            

        [TestMethod]
        public void when_Age_InBetweenSixtyToEighty()
        {
            // when age(60-79)

            TaxCalculator Age65_salaryLessThan0 = new TaxCalculator(65, -980); //salary<0
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => Age65_salaryLessThan0.IsSalaryValid(-980));

            TaxCalculator Age65_salaryEqualTo0 = new TaxCalculator(65, 0); //salary=0
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => Age65_salaryEqualTo0.IsSalaryValid(0));

            TaxCalculator Age65_salaryLessThan_ThreeLPA = new TaxCalculator(65, 285000); //salary<3LPA
            actual = Age65_salaryLessThan_ThreeLPA.CalculateTax();
            Assert.AreEqual(0, actual, 0.001, "salary not calculated correctly");

            TaxCalculator Age65_salaryEqualTo_ThreeLPA = new TaxCalculator(65, 300000); //salary=3LPA
            actual = Age65_salaryEqualTo_ThreeLPA.CalculateTax();
            Assert.AreEqual(0, actual, 0.001, "salary not calculated correctly");

            TaxCalculator Age60_salaryGreaterThan_ThreeLPA = new TaxCalculator(60, 390000); //salary>3LPA && age=60
            actual = Age60_salaryGreaterThan_ThreeLPA.CalculateTax();
            Assert.AreEqual(19500, actual, 0.001, "salary not calculated correctly");

            TaxCalculator Age65_salaryEqualTo_Five = new TaxCalculator(67, 500000); //salary=5LPA
            actual = Age65_salaryEqualTo_Five.CalculateTax();
            Assert.AreEqual(25000, actual, 0.001, "salary not calculated correctly");

            TaxCalculator Age65_salaryGreaterThan_Five = new TaxCalculator(68, 575000); //salary>5LPA
            actual = Age65_salaryGreaterThan_Five.CalculateTax();
            Assert.AreEqual(25000, actual, 0.001, "salary not calculated correctly");

            TaxCalculator Age65_salaryEqualTo_Ten = new TaxCalculator(65, 1000000); //salary=10LPA
            actual = Age65_salaryEqualTo_Ten.CalculateTax();
            Assert.AreEqual(110000, actual, 0.001, "salary not calculated correctly");

            TaxCalculator Age65_salaryGreaterThan_Ten = new TaxCalculator(78, 2000000); //salary>10LPA
            actual = Age65_salaryGreaterThan_Ten.CalculateTax();
            Assert.AreEqual(410000, actual, 0.001, "salary not calculated correctly");
        }
            

        [TestMethod]
        public void when_Age_GreaterThanEighty()
        {

            //when age(>=80)

            TaxCalculator Age85_salaryLessThan0 = new TaxCalculator(85, -980); //salary<0
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => Age85_salaryLessThan0.IsSalaryValid(-980));

            TaxCalculator Age85_salaryEqualTo0 = new TaxCalculator(85, 0); //salary=0
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => Age85_salaryEqualTo0.IsSalaryValid(0));

            TaxCalculator Age85_salaryLessThan_FiveLPA = new TaxCalculator(85, 285000); //salary<5LPA
            actual = Age85_salaryLessThan_FiveLPA.CalculateTax();
            Assert.AreEqual(0, actual, 0.001, "salary not calculated correctly");

            TaxCalculator Age85_salaryEqualTo_FiveLPA = new TaxCalculator(85, 500000); //salary=5LPA
            actual = Age85_salaryEqualTo_FiveLPA.CalculateTax();
            Assert.AreEqual(0, actual, 0.001, "salary not calculated correctly");

            TaxCalculator Age80_salaryGreaterThan_FiveLPA = new TaxCalculator(80, 590000); //salary>5LPA && age=80
            actual = Age80_salaryGreaterThan_FiveLPA.CalculateTax();
            Assert.AreEqual(118000, actual, 0.001, "salary not calculated correctly");

            TaxCalculator Age85_salaryEqualTo_TenLPA = new TaxCalculator(85, 1000000); //salary=10LPA
            actual = Age85_salaryEqualTo_TenLPA.CalculateTax();
            Assert.AreEqual(200000, actual, 0.001, "salary not calculated correctly");

            TaxCalculator Age85_salaryGreaterThan_TenLPA = new TaxCalculator(85, 2000000); //salary>10LPA
            actual = Age85_salaryGreaterThan_TenLPA.CalculateTax();
            Assert.AreEqual(400000, actual, 0.001, "salary not calculated correctly");
        }
    }
}
