namespace GradeBook
{
    public class Statistics
    {

        public Statistics(List<double> checkthestatistacs)
        {
            this.statistacs = checkthestatistacs;
        }
        public List<double> statistacs;
        public double Average
        {
            get
            {
                return statistacs.AsQueryable().Average();
            }
        }
        public double High
        {
            get
            {
                return statistacs.AsQueryable().Max();
            }
        }
        public double Low
        {
            get
            {
                return statistacs.AsQueryable().Min();
            }
        }
        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 5.5:
                        return 'A';
                      
                    case var d when d >= 4.5:
                        return 'B';
                      

                    case var d when d >= 3.5:
                        return  'C';
                    
                    case var d when d >= 2.5:
                    return 'D';
                    

                    case var d when d >= 2:
                        return  'E';
                   

                    default:
                        return  'F';
                
                }
            }
        }
    }
}