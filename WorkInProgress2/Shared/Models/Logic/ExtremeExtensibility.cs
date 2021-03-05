using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkInProgress2.Shared.Models.Logic
{
    
    public class ExtremeExtensibility<Targ, TResult>
    {
        private Func<Targ, TResult> _function;
        public ExtremeExtensibility(Func<Targ, TResult> function)
        {
            _function = function;
        }
        public TResult Execute(Targ a)
        {
            return _function(a);
        }
    }

    //// reliances on inheritance => voorbeeld abstract base class

    //public abstract class ExtremeExtensibility<Targ, TResult>
    //{
    //    public abstract TResult Execute(Targ a);
    //}
}
