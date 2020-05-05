using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Divide_whenNumEqualsZero_ReturnsNull()
        {
            int[,] firstMatrix = new int[2, 3] {{4, 34, 2}, {23, 56, 34}};

            int[,] newMatrix = Matrix.Divide(firstMatrix, 0);
            Assert.AreEqual(newMatrix, null);
        }

        [Test]
        public void Divide_whenMatrixIsNull_ReturnsNull()
        {
            int[,] firstMatrix = null;

            int[,] newMatrix = Matrix.Divide(firstMatrix, 4);
            Assert.AreEqual(newMatrix, null);
        }
        [Test]
        public void Divide_whenMatrixAndNum_ReturnsNull()
        {
            int[,] firstMatrix = new int[2, 3] {{4, 34, 2}, {22, 56, 34}};
            int[,] secMatrix = new int[2, 3] {{2, 17, 1}, {11, 28, 17}};

            int[,] newMatrix = Matrix.Divide(firstMatrix, 2);
            Assert.AreEqual(newMatrix, secMatrix);
        }
    }
}