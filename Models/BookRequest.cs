using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagerApi.Models;
public record BookRequest(string Nome, string Genero, string Autor);
