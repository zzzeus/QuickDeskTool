using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDeskTool.views
{
    class SearchItem
    {
        private string fullPath;
        public string FullPath
        {
            get
            {
                return fullPath;
            }
        }

        public string Path {
            get
            {
                return System.IO.Path.GetFileName(FullPath);
            }
        }
        private long size;
        public long Size
        {
            get
            {
                return size;
            }
        }

        public SearchItem(string path)
        {
            this.fullPath = path;
        }
        public SearchItem(string path,long size)
        {
            this.fullPath = path;
            this.size = size;
        }
    }
}
