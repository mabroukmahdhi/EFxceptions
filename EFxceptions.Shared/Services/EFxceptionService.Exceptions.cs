﻿// ---------------------------------------------------------------
// Copyright (c) The Standard Community. All rights reserved.
// ---------------------------------------------------------------

using EFxceptions.Models.Exceptions;

namespace EFxceptions.Services
{
    public partial class EFxceptionService<TDbException>
    {
        private void ConvertAndThrowMeaningfulException(int code, string message)
        {
            switch (code)
            {
                case 207:
                    throw new InvalidColumnNameException(message);
                case 208:
                    throw new InvalidObjectNameException(message);
                case 547:
                    throw new ForeignKeyConstraintConflictException(message);
                case 2601:
                    throw new DuplicateKeyWithUniqueIndexException(message);
                case 2627:
                    throw new DuplicateKeyException(message);
            }
        }
    }
}