using System;
using System.Collections.Generic;
using System.Text;

namespace PRManagementusinglinq
{
    class ProductReview
    {
        public int ProductId
        { get;
          set;
        }
        public int UserID
        { get;
          set;
        }
        public double Rating
        { get;
          set;
        }
        public string Review
        {get;
         set;
        }
        public bool isLike
        { get;
          set;
        }
    }
}
