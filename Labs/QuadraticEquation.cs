using System;
using System.Collections.Generic;



namespace Labs
{
    class QuadraticEquation : LinearEquation
    {
        public List<double> Solve(double a, double b, double c)
        {
            if (a == 0)
            {
                return SolveLinearEquation(b, c);
            }

            double descriminant = SolveDesriminant(a, b, c);
            if (descriminant < 0)
            {
                throw new Exception("Ошибка: уравнение не имеет решений");
            }
            if (descriminant == 0)
            {
                return DescrEqualToZeroSolution(a, b);
            }
            else
            {
                return DescrMoreThanZeroSolution(a, b, descriminant);


            }
        }
        private double SolveDesriminant(double a, double b, double c)
        {
            return (b * b) - 4 * a * c;
        }

        private List<double> DescrEqualToZeroSolution(double a, double b)
        {
            return x = new List<double>() { -(b / (2 * a)) };
        }

        private List<double> DescrMoreThanZeroSolution(double a, double b, double discriminant)
        {
            discriminant = Math.Sqrt(discriminant);
            return new List<double>() { (-b + discriminant) / (2 * a), (-b - discriminant) / (2 * a) };

        }
    }

}