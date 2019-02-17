﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Decorator
{
    class Circle : Shape
    {
        private float m_radius;

        public Circle(CircleShape component) : base(component)
        {
            m_radius = component.Radius;
        }

        public override float GetPerimeter()
        {
            return (3.14f * this.m_radius * 2);
        }

        public override float GetArea()
        {
            return (3.14f * this.m_radius * this.m_radius);
        }

        public override string GetDescription()
        {
            return "CIRCLE:" + base.GetDescription();
        }
    }
}
