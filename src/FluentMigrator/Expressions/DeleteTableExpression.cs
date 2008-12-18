﻿using System;
using System.Collections.Generic;
using FluentMigrator.Infrastructure;

namespace FluentMigrator.Expressions
{
	public class DeleteTableExpression : IMigrationExpression
	{
		public virtual string TableName { get; set; }

		public virtual void CollectValidationErrors(ICollection<string> errors)
		{
			if (String.IsNullOrEmpty(TableName))
				errors.Add(ErrorMessages.TableNameCannotBeNullOrEmpty);
		}

		public virtual void ExecuteWith(IMigrationProcessor processor)
		{
			processor.Process(this);
		}
	}
}