﻿namespace Assets.Project4.Task4
{
    public class Human : Enemy
    {
        public override void Accept(IEnemyVisitor visitor) => visitor.Visit(this);
    }
}