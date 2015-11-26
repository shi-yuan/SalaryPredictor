using weka.classifiers;
using weka.core;

namespace SalaryPredictor
{
    public class KNNPredictor
    {
        private Classifier cl;

        private Instances header;

        public KNNPredictor()
        {
            init();
        }

        /// <summary>
        /// 初始化分类器
        /// </summary>
        private void init()
        {
            object[] arr = SerializationHelper.readAll("Resources/ibk.save");
            cl = (Classifier)arr[0];
            header = (Instances)arr[1];
        }

        /// <summary>
        /// 预测薪资
        /// </summary>
        /// <param name="jobScore">职位得分</param>
        /// <param name="schoolScore">学校得分</param>
        /// <param name="degreeScore">学历得分</param>
        /// <param name="addrScore">地区得分</param>
        /// <param name="year">工作年限</param>
        /// <returns>预估薪资</returns>
        public double predicate(double jobScore, double schoolScore, double degreeScore, double addrScore, double year)
        {
            Instance inst = new DenseInstance(header.numAttributes());
            inst.setDataset(header);
            // 职位得分
            inst.setValue(0, jobScore);
            // 学校得分
            inst.setValue(1, schoolScore);
            // 学历得分
            inst.setValue(2, degreeScore);
            // 地区得分
            inst.setValue(3, addrScore);
            // 工作年限
            inst.setValue(4, year);
            // 薪资(待预测)
            inst.setValue(5, 0);
            return cl.classifyInstance(inst);
        }
    }
}
