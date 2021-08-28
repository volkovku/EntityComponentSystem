namespace ECS
{
    public interface ISystem
    {
        void Init(EntityManager entityManager);
        void Update(EntityManager entityManager);
    }
}