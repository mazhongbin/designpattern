namespace DP05Adapter
{
    public class Translator : Player
    {
        private ChinesePlayer _adaptee = new ChinesePlayer { 名字 = "姚明" };

        public override void Attack()
        {
            _adaptee.进攻();
        }

        public override void Defense()
        {
            _adaptee.防守(); 
        }
    }
}
