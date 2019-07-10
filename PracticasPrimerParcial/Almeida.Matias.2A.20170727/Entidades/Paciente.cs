﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        private int turno;
        private static int ultimoTurnoDado;

        public int Turno
        {
            get { return this.turno; }
        }

        static Paciente()
        {
            ultimoTurnoDado = 0;
        }

        public Paciente(string nombre, string apellido) : base(nombre, apellido)
        {
            ultimoTurnoDado += 1;
            this.turno = ultimoTurnoDado;
        }

        public Paciente(string nombre, string apellido, int turno) : base(nombre, apellido)
        {
            this.turno = turno;
            ultimoTurnoDado = turno;
        }

        public override string ToString()
        {
            return string.Format("Turno N°{0}: {2}, {1}", this.Turno, this.nombre, this.apellido);
        }
    }
}
