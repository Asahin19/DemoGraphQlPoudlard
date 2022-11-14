using GraphQL.Types;
using PoudlardAPI.DataModel.Enum;

namespace PoudlardAPI.Graphql.Types.Enum
{
    public class HouseEnum : EnumerationGraphType<House>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerCompensationTypeEnum"/> class.
        /// </summary>
        public HouseEnum()
        {
            this.Name = nameof(HouseEnum);
        }

        /// <summary>
        /// Overrides the case transformation for this enum.
        /// </summary>
        /// <param name="val">The enum string value.</param>
        /// <returns>The transformed enum string value.</returns>
        protected override string ChangeEnumCase(string val) => val;
    }
}
