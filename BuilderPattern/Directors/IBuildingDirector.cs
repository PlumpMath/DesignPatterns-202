using BuilderPattern.House_Builder;

namespace BuilderPattern.Directors
{
    public interface IBuildingDirector
    {
        void Construct(IBuildingBuilder builder);

    }
}
