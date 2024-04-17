using UnityEngine;

namespace Assets.Task3
{
    [RequireComponent(typeof(Collider))]
    public abstract class Seller : ISeller
    {
        private const string GoodbyeMassage = "Я не торгую с сомнительными личностями";
        private const string WelcomeMassage = "Приветствую! для тебя у меня только такие товары";

        public void Trade(int reputation)
        {
            if (reputation <= 0)
            {
                Debug.Log(GoodbyeMassage);
                return;
            }

            Debug.Log(WelcomeMassage);
            ShowProduct();
        }

        protected abstract void ShowProduct();
    }
}