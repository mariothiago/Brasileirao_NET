﻿using System.ComponentModel.DataAnnotations;
using Brasileirao.Domain.Model;

namespace Brasileirao.Domain.DTOs.Palpite;
public class InsertPalpitesDTO
{
    [Required(ErrorMessage = "Partida é obrigatória")]
    public int Partida { get; set; }
    [Required(ErrorMessage = "Placar do time mandante é obrigatório")]
    public int PlacarMandante { get; set; }
    [Required(ErrorMessage = "Placar do time visitante é obrigatório")]
    public int PlacarVisitante { get; set; }

    public Palpites GetModel()
    {
        return new Palpites
        {
            Partida = Partida,
            PlacarMandante = PlacarMandante,
            PlacarVisitante = PlacarVisitante
        };
    }
}

