using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;
using Services;

namespace Services.Tests
{
  [TestClass()]
  public class ServicesCharngauzerSquareTests
  {
    [TestMethod()]
    public void GetPointsTest()
    {
      int constA = 1, leftBorder = -1, rightBorder = 1, step = 1;
      ServicesCharngauzerSquare graph = new ServicesCharngauzerSquare();
      double[] answers = new double[6];
      answers[0] = 1.9051586888313607;
      answers[1] = -1.9051586888313607;
      answers[2] = 1.5396007178390021;
      answers[3] = -1.5396007178390021;
      answers[4] = 0;
      answers[5] = 0;
      var points = graph.GetPoints(constA, leftBorder, rightBorder, step);
      for(int i = 0; i < answers.Length; i++)
      {
        Assert.AreEqual(answers[i], points[i].y);
      }
    }
  }
}