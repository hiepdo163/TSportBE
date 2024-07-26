﻿using System;
using System.Collections.Generic;

namespace TSport.Api.Repositories.Entities;

public partial class Player
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string Name { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int? ClubId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedAccountId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedAccountId { get; set; }

    public virtual Club? Club { get; set; }

    public virtual Account CreatedAccount { get; set; } = null!;

    public virtual Account? ModifiedAccount { get; set; }

    public virtual ICollection<SeasonPlayer> SeasonPlayers { get; set; } = new List<SeasonPlayer>();
}
