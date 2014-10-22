using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ParticleRepeller : Particle
    {
        public int Range { get; private set; }
        public int Power { get; private set; }

        public ParticleRepeller(MatrixCoords position, MatrixCoords speed, uint reppelerPower, uint radiusOfEffect)
            : base(position, speed)
        {
            this.Range = (int)radiusOfEffect;
            this.Power = (int)reppelerPower;
        }

        public override char[,] GetImage()
        {
            return new char[,] { { (char)2 } };
        }
    }
}
