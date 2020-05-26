﻿// <copyright file="ISearchRentalUnitsRepository.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Features.SearchRentalUnits
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Domain.RentalInventory.Models;

    public interface ISearchRentalUnitsRepository
    {
        Task<IEnumerable<RentalUnit>> SearchRentalUnits(string name);
    }
}
