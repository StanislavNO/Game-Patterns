using UnityEngine;

namespace Assets.Task3
{
    [RequireComponent(typeof(Collider))]
    public abstract class Seller : ISeller
    {
        private const string GoodbyeMassage = "� �� ������ � ������������� ����������";
        private const string WelcomeMassage = "�����������! ��� ���� � ���� ������ ����� ������";

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