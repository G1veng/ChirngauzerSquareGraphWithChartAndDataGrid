using System.Collections.Generic;

namespace Services
{
    public interface ICharngauzerSquare
    {
       public List<ModelCharngauzerSquare> GetPoints(double a, double leftBorder, double rigthBorder, double step);
    }
}
