

namespace Labs
{
    public class A : B
    {

        private object firstRef;
        private object secondRef;

        public object GetFirstRef()
        {
            return this.firstRef;
        }
        public void SetFirstRef(object a)
        {
            this.firstRef = a;
        }

        public object GetSecondRef()
        {
            return this.secondRef;
        }
        public void SetSecondRef(object a)
        {
            this.secondRef = a;
        }
        public A() { }
        public A(object firstRef, object secondRef)
        {
            this.firstRef = firstRef;
            this.secondRef = secondRef;
        }


    }
}