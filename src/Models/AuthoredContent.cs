
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Miniblog.Core.Models
{
    interface AuthoredContent {
        string GetGravatar();
    }
}
