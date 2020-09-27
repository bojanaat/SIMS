/***********************************************************************
 * Module:  IRepozitorijum.cs
 * Author:  Bojana
 * Purpose: Definition of the Interface IRepozitorijum
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IRepozitorijum
{
   void Sacuvaj(Object obj);
   List<Object> Ucitaj();
}