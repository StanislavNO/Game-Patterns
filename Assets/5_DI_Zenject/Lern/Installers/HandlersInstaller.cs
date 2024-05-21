using System;
using Zenject;
using UnityEngine;

namespace Assets.Project5.DI
{
    public class HandlersInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<MovementHandler>().AsSingle();
        }
    }
}