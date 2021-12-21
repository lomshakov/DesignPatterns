using System;

namespace TemplateMethod
{
    /// <summary>
    /// Абстрактный класс, содержащий шаблонный метод
    /// </summary>
    abstract class Frame
    {
        protected abstract void CutBlank();

        protected abstract void FrameProcess();

        protected void Paint()
        {
            Console.WriteLine("Покраска детали");
        }

        // Шаблонный метод
        public void Make()
        {
            CutBlank();
            FrameProcess();
            Paint();
        }
    }

    /// <summary>
    /// Нижняя деталь
    /// </summary>
    class BottomPart : Frame
    {
        protected override void CutBlank()
        {
            Console.WriteLine("Вырезать заготовку");
        }

        protected override void FrameProcess()
        {
            Console.WriteLine("Обработка нижней детали...");
        }
    }

    /// <summary>
    /// Верхняя деталь
    /// </summary>
    class TopPart : Frame
    {
        protected override void CutBlank()
        {
            Console.WriteLine("Вырезание заготовки для верхней детали");
        }

        protected override void FrameProcess()
        {
            Console.WriteLine("Обработка верхней детали...");
        }
    }
}