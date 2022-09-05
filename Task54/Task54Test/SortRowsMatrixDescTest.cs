using Xunit;
using Task54;

namespace Task54Test
{
    public class SortRowsMatrixDescTest
    {
        [Fact]
        public void TestMethod()
        {
            //arrange
            int[,] arrActual = new int[,] {{1, 2, 3}, {4, 5, 6}};
            int[,] arrExpect = new int[,] {{3, 2, 1}, {6, 5, 4}};
            //act
            Program.SortRowsMatrixDesc(arrActual);
            //assert
            Assert.Equal(arrExpect ,arrActual);
        }
    }
}