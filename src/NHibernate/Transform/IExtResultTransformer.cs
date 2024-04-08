using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Type;

namespace NHibernate.Transform
{
	public interface IExtResultTransformer : IResultTransformer
	{
		object TransformTuple(object[] tuple, string[] aliases, IType[] types);
	}
}
