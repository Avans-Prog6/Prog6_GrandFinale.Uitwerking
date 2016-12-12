using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Prog6_GrandFinale.Domain;

namespace Prog6_GrandFinale.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPokemonService
    {

        [OperationContract]
        IEnumerable<Pokemon> GetPokemons();

        [OperationContract]
        Pokemon CreatePokemons(Pokemon composite);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Pokemon
    {
        public Pokemon()
        {

        }

        public Pokemon(Domain.Pokemon p)
        {
            Name = p.Name;
            DateOfBirth = p.DateOfBirth;
            Type = p.Type;
            Level = p.Level; 
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Type { get; set; }


        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public int Level { get; set; }

        internal Domain.Pokemon ToPoco()
        {
            return new Domain.Pokemon()
            {
                Name = this.Name,
                DateOfBirth = this.DateOfBirth,
                Type = this.Type,
                Level = this.Level
            };
        }
    }
}
