namespace DP17Iterator.V1
{
    public class ClazzIterator : Iterator<Student>
    {
        private Clazz myClazz = null;
        private int index;

        public ClazzIterator(Clazz clazz)
        {
            myClazz = clazz;
        }


        public override bool IsDone
        {
            get
            {
                return this.index == myClazz.StudentCount - 1;
            }
        }

        public override Student Current()
        {
            return myClazz[index];
        }

        public override Student Next()
        {
            this.index++;
            return myClazz[index];
        }
    }
}
