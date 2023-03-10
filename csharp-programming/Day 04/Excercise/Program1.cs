namespace Excercise {
    class Polynomial {
        class Term {
            public Term(int coeff, int power) {
                Coeff = coeff;
                Power = power;
            }
            public int Coeff { get; set; }
            public int Power { get; set; }
        }

        List<Term> terms;

        public Polynomial() {
            terms = new List<Term>();
        }

        public int this[int power] {
            get { 
                foreach (Term term in terms) {
                    if (term.Power == power) {
                        return term.Coeff;
                    }
                }
                return 0;
            }
            set { 
                foreach (Term term in terms) {
                    if (term.Power == power) {
                        term.Coeff = value;
                        return;
                    }
                }
                Term temp = new Term(value, power);
                for(int i=0; i<GetLength(); i++) {
                    if (terms[i].Power <= temp.Power) {
                        terms.Insert(i, temp);
                        return;
                    }
                }
                terms.Add(temp);
            }
        }

        public void AddTerm(int coeff, int power) {
            Term temp = new Term(coeff, power);
            foreach(Term p in terms) {
                if(p.Power == temp.Power) {
                    throw new Exception("Power already present...");
                }
            }
            for (int i = 0; i < GetLength(); i++) {
                if (terms[i].Power <= temp.Power) {
                    terms.Insert(i, temp);
                    return;
                }
            }
            terms.Add(temp);
            terms.Add(temp);
        }

        int GetLength() {
            return terms.Count;
        }

        public double Evaluate(int x) {
            double result = 0.0;
            for(int i=0; i<GetLength(); i++) {
                result += terms[i].Coeff * Math.Pow(x, terms[i].Power);
            }
            return result;
        }
    }

    class Program {
        public static void Main(string[] args) {
            Polynomial polynomial = new Polynomial();
            polynomial.AddTerm(2, 0);
            polynomial.AddTerm(3, 1);
            polynomial.AddTerm(5, 4);
            polynomial[1] = 3;
            polynomial[3] = 1;
            Console.WriteLine(polynomial.Evaluate(2) + " " + polynomial[0]);
            Console.WriteLine(polynomial.Evaluate(1) + " " + polynomial[1]);
            Console.WriteLine(polynomial.Evaluate(4) + " " + polynomial[4]);
            Console.WriteLine(polynomial.Evaluate(3) + " " + polynomial[3]);
        }
    }
}