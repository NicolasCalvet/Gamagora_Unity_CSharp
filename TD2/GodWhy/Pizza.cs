using System;
using System.Collections.Generic;
using System.Text;

namespace GodWhy {
    class Pizza {

        public float rayon;
        public float prix;

        public Pizza(float rayon, float prix) {
            this.rayon = rayon;
            this.prix = prix;
        }

        public float Efficiency() {
            return MathF.Pow(rayon, 2.0f) * MathF.PI / prix;
        }
    }
}
