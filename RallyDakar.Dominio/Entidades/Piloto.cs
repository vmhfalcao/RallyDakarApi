﻿using System;

namespace RallyDakar.Dominio.Entidades
{
    public class Piloto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EquipeId { get; set; }
        public virtual Equipe Equipe { get; set; } //Carrega automaticamente os dados da Equipe
    }
}
