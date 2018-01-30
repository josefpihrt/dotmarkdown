// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown.Linq
{
    public abstract class MList : MContainer
    {
        protected MList()
        {
        }

        protected MList(object content)
            : base(content)
        {
        }

        protected MList(params object[] content)
            : base(content)
        {
        }

        protected MList(MList other)
            : base(other)
        {
        }

        internal override bool AllowStringConcatenation => false;
    }
}
