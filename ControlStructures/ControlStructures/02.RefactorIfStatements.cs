namespace ControlStructures
{
    using System;

    public class RefactorIfStatements
    {
        public class Potato
        {
            public bool IsPeeled()
            {
                throw new NotImplementedException();
            }
            
            public bool IsHealthy() // Previously "IsRotten", it sounded aufull
            {
                throw new NotImplementedException();
            }
        }

        Potato potato = new Potato();
            //... 
        public void CheckPotato()
        {
            if (potato != null)
            {
                if (ReadyForCooking(potato))
                {
                    Cook(potato);
                }
            }
        }

         public bool ReadyForCooking(Potato currentPotato)
        {
            if (currentPotato.IsHealthy() && currentPotato.IsPeeled())
            {
                return true;
            }

            else
            {
                return false;
            }
        }
       
        public class MatrixThings
        {
            public void CheckVisited(Matrix matrix)
            {
                if ((x >= minX && x <= maxX) && (y >= minY && y <= maxY) && !isVisitedCell)
                {
                    VisitCell();
                }
            }
        }
    }
}

