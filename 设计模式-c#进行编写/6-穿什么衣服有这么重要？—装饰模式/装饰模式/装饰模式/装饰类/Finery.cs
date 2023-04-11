namespace 装饰模式.装饰类
{
    class Finery : Person
    {
        protected Person component;

        public void Decorate(Person component)
        {
            this.component = component;
        }
        public override void Show()
        {
            if(component != null)
            {
                component.Show();
            }
        }
    }
}
