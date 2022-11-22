using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.IO;

namespace PdfSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            //SplitPdf();
            //SplitPdfWithSpecificContentForCLF_C01(); // v2.9
            //SplitPdfWithSpecificContentForSAA_C03_1(); // v4.9.3
            //SplitPdfWithSpecificContentForSAA_C03_2(); // v5.0.2
            //SplitPdfWithSpecificContentForSAA_C03_3(); // v5.2.0
            //SplitPdfWithSpecificContentForDVA_C01_1(); // v4.10.0
            //SplitPdfWithSpecificContentForDVA_C01_2(); // v4.11.2
            SplitPdfWithSpecificContentForSOA_C02_1(); // v3.7.2
        }

        // v3.7.2
        private static void SplitPdfWithSpecificContentForSOA_C02_1()
        {
            string pdfFilePath = @"C:\Users\HumanR0006\sample.pdf";
            string outputPath = @"C:\Users\HumanR0006\PDF";
            List<Content> contentList = new List<Content>();

            // Section 3: EC2 for SysOps
            contentList.Add(new Content
            {
                contentName = "Section_03_EC2 for SysOps", // Rocking EC2 from a SysOps perspective
                startPage = 9,
                numberOfPage = 44
            });

            // Section 4: AMI - Amazon Machine Image
            contentList.Add(new Content
            {
                contentName = "Section_04_AMI Section",
                startPage = 53,
                numberOfPage = 12
            });

            // Section 5: Managing EC2 at Scale - Systems Manager(SSM) & Opswork
            contentList.Add(new Content
            {
                contentName = "Section_05_Management of EC2 at scale", // Systems Manager & OpsWorks
                startPage = 65,
                numberOfPage = 24
            });

            // Section 6: EC2 High Availability and Scalability
            contentList.Add(new Content
            {
                contentName = "Section_06_EC2 High Availability and Scalability", // Load Balancer and Auto Scaling Groups
                startPage = 89,
                numberOfPage = 64
            });

            // Section 7: Elastic Beanstalk for SysOps
            contentList.Add(new Content
            {
                contentName = "Section_07_Elastic Beanstalk",
                startPage = 153,
                numberOfPage = 7
            });

            // Section 8: CloudFormation for SysOps
            contentList.Add(new Content
            {
                contentName = "Section_08_AWS CloudFormation", // Managing your infrastructure as code
                startPage = 160,
                numberOfPage = 50
            });

            // Section 9: EC2 Storage and Data Management - EBS and EFS
            contentList.Add(new Content
            {
                contentName = "Section_09_EC2 Storage and Data Management", // EBS, Instance Store & EFS
                startPage = 210,
                numberOfPage = 29
            });

            // Section 10: Amazon S3 Introduction
            contentList.Add(new Content
            {
                contentName = "Section_10_S3 Storage and Data Management", // S3, Glacier, Athena
                startPage = 239,
                numberOfPage = 29
            });

            //// Section 11: Advanced Amazon S3 & Athena
            //contentList.Add(new Content
            //{
            //    contentName = "Section_11_Advanced Amazon S3",
            //    startPage = 239,
            //    numberOfPage =
            //});

            // Section 12: Amazon S3 Security
            contentList.Add(new Content
            {
                contentName = "Section_12_Amazon S3 Security",
                startPage = 268,
                numberOfPage = 24
            });

            // Section 13: Advanced Storage Section
            contentList.Add(new Content
            {
                contentName = "Section_13_Advanced Storage Solutions",
                startPage = 292,
                numberOfPage = 32
            });

            // Section 14: CloudFront
            contentList.Add(new Content
            {
                contentName = "Section_14_CloudFront",
                startPage = 324,
                numberOfPage = 23
            });

            // Section 15: Database for SysOps
            contentList.Add(new Content
            {
                contentName = "Section_15_Databases",
                startPage = 347,
                numberOfPage = 45
            });

            // Section 16: Monitoring, Auditing and Performance
            contentList.Add(new Content
            {
                contentName = "Section_16_AWS Monitoring, Audit and Performance", // CloudWatch, CloudTrail & AWS Config
                startPage = 392,
                numberOfPage = 39
            });

            // Section 17: AWS Account Management
            contentList.Add(new Content
            {
                contentName = "Section_17_AWS Account Management", // Health Dashboards, AWS Organizations and Billing Console
                startPage = 431,
                numberOfPage = 29
            });

            // Section 18: Disaster Recovery
            contentList.Add(new Content
            {
                contentName = "Section_18_Disaster Recovery",
                startPage = 460,
                numberOfPage = 8
            });

            // Section 19: Security & Compliance for SysOps
            contentList.Add(new Content
            {
                contentName = "Section_19_Security and Compliance",
                startPage = 468,
                numberOfPage = 52
            });

            // Section 20: Identity
            contentList.Add(new Content
            {
                contentName = "Section_20_Identity",
                startPage = 520,
                numberOfPage = 18
            });

            // Section 22: Networking - VPC
            contentList.Add(new Content
            {
                contentName = "Section_22_Virtual Private Cloud (VPC)",
                startPage = 538,
                numberOfPage = 84

            });

            // Section 21: Networking - Route 53
            contentList.Add(new Content
            {
                contentName = "Section_21_Route 53",
                startPage = 622,
                numberOfPage = 37
            });

            // Section 23: Other Services
            contentList.Add(new Content
            {
                contentName = "Section_23_Other Services",
                startPage = 659,
                numberOfPage = 10
            });

            // Section 24: Preparing for the Exam +Practice Exam - AWS Certified SysOps Administrator
            contentList.Add(new Content
            {
                contentName = "Section_24_Exam Review & Tips",
                startPage = 669,
                numberOfPage = 4
            });

            // Section 25: Congratulations - AWS Certified SysOps Administrator
            contentList.Add(new Content
            {
                contentName = "Section_25_Congratulations!",
                startPage = 673,
                numberOfPage = 2
            });

            Program obj = new Program();
            foreach (var content in contentList)
            {
                obj.SplitAndSaveInterval(pdfFilePath, outputPath, content.startPage, content.numberOfPage, content.contentName);
                System.Console.WriteLine(content.contentName);
            }
            System.Console.WriteLine("Finished!");
            System.Console.ReadKey();
        }

        // v4.11.2
        private static void SplitPdfWithSpecificContentForDVA_C01_2()
        {
            string pdfFilePath = @"C:\Users\HumanR0006\sample.pdf";
            string outputPath = @"C:\Users\HumanR0006\PDF";
            List<Content> contentList = new List<Content>();

            // Section 3: Getting started with AWS
            contentList.Add(new Content
            {
                contentName = "Section_03_Getting started with AWS",
                startPage = 9,
                numberOfPage = 10
            });

            // Section 4: IAM & AWS CLI
            contentList.Add(new Content
            {
                contentName = "Section_04_IAM Section",
                startPage = 19,
                numberOfPage = 18
            });

            // Section 5: EC2 Fundamentals
            contentList.Add(new Content
            {
                contentName = "Section_05_EC2 Basics",
                startPage = 37,
                numberOfPage = 33
            });

            // Section 6: EC2 Instance Storage
            contentList.Add(new Content
            {
                contentName = "Section_06_EC2 Instance Storage Section",
                startPage = 70,
                numberOfPage = 23
            });

            // Section 7: AWS Fundamentals: ELB + ASG
            contentList.Add(new Content
            {
                contentName = "Section_07_ELB,ASG & EBS",   // AWS Fundamentals – Part II
                                                            // Load Balancing, Auto Scaling Groups and EBS Volumes
                startPage = 93,
                numberOfPage = 42
            });

            // Section 8: AWS Fundamentals: RDS + Aurora + ElastiCache
            contentList.Add(new Content
            {
                contentName = "Section_08_RDS, Aurora & ElastiCache",   // AWS Fundamentals – Part III
                startPage = 135,
                numberOfPage = 29
            });

            // Section 9: Route 53
            contentList.Add(new Content
            {
                contentName = "Section_09_Route 53 Section",
                startPage = 164,
                numberOfPage = 31
            });

            // Section 10: VPC Fundamentals
            contentList.Add(new Content
            {
                contentName = "Section_10_VPC Primer", // Quick Overview of VPC
                startPage = 195,
                numberOfPage = 17
            });

            // Section 11: Amazon S3 Introduction
            contentList.Add(new Content
            {
                contentName = "Section_11_Amazon S3", // Another base block of AWS
                startPage = 212,
                numberOfPage = 25
            });

            // Section 12: AWS CLI, SDK, IAM Roles & Policies
            contentList.Add(new Content
            {
                contentName = "Section_12_Developing on AWS", // CLI, SDK and IAM Policies
                startPage = 237,
                numberOfPage = 15
            });

            // Section 13: Advanced Amazon S3
            contentList.Add(new Content
            {
                contentName = "Section_13_Advanced S3",
                startPage = 252,
                numberOfPage = 12
            });

            // Section 14: Amazon S3 Security
            contentList.Add(new Content
            {
                contentName = "Section_14_Amazon S3 Security",
                startPage = 264,
                numberOfPage = 18
            });

            // Section 15: CloudFront
            contentList.Add(new Content
            {
                contentName = "Section_15_CloudFront",
                startPage = 282,
                numberOfPage = 20
            });

            // Section 16: ECS, ECR & Fargate - Docker in AWS
            contentList.Add(new Content
            {
                contentName = "Section_16_Container Section",
                startPage = 302,
                numberOfPage = 40
            });

            // Section 17: AWS Elastic Beanstalk
            contentList.Add(new Content
            {
                contentName = "Section_17_AWS Elastic Beanstalk", // Deploying applications in AWS safely and predictably
                startPage = 342,
                numberOfPage = 31
            });

            // Section 18: AWS CICD: CodeCommit, CodePipeline, CodeBuild, CodeDeploy
            contentList.Add(new Content
            {
                contentName = "Section_18_AWS CICD", // CodeCommit, CodePipeline, CodeBuild, CodeDeploy, …
                startPage = 373,
                numberOfPage = 39
            });

            // Section 19: AWS CloudFormation
            contentList.Add(new Content
            {
                contentName = "Section_19_AWS CloudFormation", // Managing your infrastructure as code
                startPage = 412,
                numberOfPage = 43
            });

            // Section 20: AWS Monitoring & Audit: CloudWatch, X-Ray and CloudTrail
            contentList.Add(new Content
            {
                contentName = "Section_20_AWS Monitoring, Troubleshooting & Audit", // CloudWatch, X-Ray and CloudTrail
                startPage = 455,
                numberOfPage = 49
            });

            // Section 21: AWS Integration & Messaging: SQS, SNS & Kinesis
            contentList.Add(new Content
            {
                contentName = "Section_21_AWS Integration & Messaging", // SQS, SNS & Kinesis
                startPage = 504,
                numberOfPage = 63
            });

            // Section 22: AWS Serverless: Lambda
            contentList.Add(new Content
            {
                contentName = "Section_22_AWS Lambda", // It’s a serverless world
                startPage = 567,
                numberOfPage = 61
            });

            // Section 23: AWS Serverless: DynamoDB
            contentList.Add(new Content
            {
                contentName = "Section_23_DynamoDB", // NoSQL Serverless Database
                startPage = 628,
                numberOfPage = 47
            });

            // Section 24: AWS Serverless: API Gateway
            contentList.Add(new Content
            {
                contentName = "Section_24_API Gateway", // Build, Deploy and Manage APIs
                startPage = 675,
                numberOfPage = 42
            });

            // Section 25: AWS Serverless: SAM - Serverless Application Model
            contentList.Add(new Content
            {
                contentName = "Section_25_AWS Serverless Application Model (SAM)", // Taking your Serverless Development to the next level
                startPage = 717,
                numberOfPage = 9
            });

            // Section 26: Cloud Devlopment Kit(CDK)
            contentList.Add(new Content
            {
                contentName = "Section_26_AWS Cloud Development Kit",
                startPage = 726,
                numberOfPage = 5
            });

            // Section 27: Cognito: Cognito User Pools, Cognito Identity Pools & Cognito Sync
            contentList.Add(new Content
            {
                contentName = "Section_27_Amazon Cognito Section",
                startPage = 731,
                numberOfPage = 17
            });

            // Section 28: Other Serverless: Step Functions & AppSync
            contentList.Add(new Content
            {
                contentName = "Section_28_Other Serverless Section",
                startPage = 748,
                numberOfPage = 19
            });

            // Section 29: Advanced Identity
            contentList.Add(new Content
            {
                contentName = "Section_29_Advanced Identity Section",
                startPage = 767,
                numberOfPage = 22
            });

            // Section 30: AWS Security & Encryption: KMS, Encryption SDK, SSM Parameter Store, IAM & STS
            contentList.Add(new Content
            {
                contentName = "Section_30_AWS Security & Encryption", // KMS, Encryption SDK, SSM Parameter Store
                startPage = 789,
                numberOfPage = 33
            });

            // Section 31: AWS Other Services
            contentList.Add(new Content
            {
                contentName = "Section_31_Other AWS Services", // Quick overview of other services that might have questions on at the exam
                startPage = 822,
                numberOfPage = 9
            });

            // Section 32: AWS Final Cleanup
            contentList.Add(new Content
            {
                contentName = "Section_32_Exam Review & Tips",
                startPage = 831,
                numberOfPage = 9
            });

            //// Section 33: Preparing for the Exam - AWS Certified Developer Associate
            //contentList.Add(new Content
            //{
            //    contentName = "Section_33_Congratulations & Next Steps!",
            //    startPage = 840,
            //    numberOfPage = 30
            //});

            // Section 34: Congratulations - AWS Certified Developer Associate
            contentList.Add(new Content
            {
                contentName = "Section_34_Congratulations & Next Steps!",
                startPage = 840,
                numberOfPage = 3
            });

            Program obj = new Program();
            foreach (var content in contentList)
            {
                obj.SplitAndSaveInterval(pdfFilePath, outputPath, content.startPage, content.numberOfPage, content.contentName);
                System.Console.WriteLine(content.contentName);
            }
            System.Console.WriteLine("Finished!");
            System.Console.ReadKey();
        }

        // v4.10.0
        private static void SplitPdfWithSpecificContentForDVA_C01_1()
        {
            string pdfFilePath = @"C:\Users\HumanR0006\sample.pdf";
            string outputPath = @"C:\Users\HumanR0006\PDF";
            List<Content> contentList = new List<Content>();

            // Section 3: Getting started with AWS
            contentList.Add(new Content
            {
                contentName = "Section_03_Getting started with AWS",
                startPage = 9,
                numberOfPage = 10
            });

            // Section 4: IAM & AWS CLI
            contentList.Add(new Content
            {
                contentName = "Section_04_IAM Section",
                startPage = 19,
                numberOfPage = 18
            });

            // Section 5: EC2 Fundamentals
            contentList.Add(new Content
            {
                contentName = "Section_05_EC2 Basics",
                startPage = 37,
                numberOfPage = 33
            });

            // Section 6: EC2 Instance Storage
            contentList.Add(new Content
            {
                contentName = "Section_06_EC2 Instance Storage Section",
                startPage = 70,
                numberOfPage = 23
            });

            // Section 7: AWS Fundamentals: ELB + ASG
            contentList.Add(new Content
            {
                contentName = "Section_07_ELB,ASG & EBS",   // AWS Fundamentals – Part II
                                                            // Load Balancing, Auto Scaling Groups and EBS Volumes
                startPage = 93,
                numberOfPage = 42
            });

            // Section 8: AWS Fundamentals: RDS + Aurora + ElastiCache
            contentList.Add(new Content
            {
                contentName = "Section_08_RDS, Aurora & ElastiCache",   // AWS Fundamentals – Part III
                startPage = 135,
                numberOfPage = 29
            });

            // Section 9: Route 53
            contentList.Add(new Content
            {
                contentName = "Section_09_Route 53 Section",
                startPage = 164,
                numberOfPage = 31
            });

            // Section 10: VPC Fundamentals
            contentList.Add(new Content
            {
                contentName = "Section_10_VPC Primer", // Quick Overview of VPC
                startPage = 195,
                numberOfPage = 17
            });

            // Section 11: Amazon S3 Introduction
            contentList.Add(new Content
            {
                contentName = "Section_11_Amazon S3", // Another base block of AWS
                startPage = 212,
                numberOfPage = 21
            });

            // Section 12: AWS CLI, SDK, IAM Roles & Policies
            contentList.Add(new Content
            {
                contentName = "Section_12_Developing on AWS", // CLI, SDK and IAM Policies
                startPage = 233,
                numberOfPage = 44
            });

            //// Section 13: Advanced S3 & Athena
            //contentList.Add(new Content
            //{
            //    contentName = "Section_13_CloudFront Section",
            //    startPage = 274, // 276
            //    numberOfPage = 30
            //});

            // Section 14: CloudFront
            contentList.Add(new Content
            {
                contentName = "Section_14_CloudFront Section",
                startPage = 277,
                numberOfPage = 22
            });

            // Section 15: ECS, ECR & Fargate - Docker in AWS
            contentList.Add(new Content
            {
                contentName = "Section_15_Container Section",
                startPage = 299,
                numberOfPage = 40
            });

            // Section 16: AWS Elastic Beanstalk
            contentList.Add(new Content
            {
                contentName = "Section_16_AWS Elastic Beanstalk", // Deploying applications in AWS safely and predictably
                startPage = 339,
                numberOfPage = 31
            });

            // Section 17: AWS CICD: CodeCommit, CodePipeline, CodeBuild, CodeDeploy
            contentList.Add(new Content
            {
                contentName = "Section_17_AWS CICD", // CodeCommit, CodePipeline, CodeBuild, CodeDeploy, …
                startPage = 370,
                numberOfPage = 39
            });

            // Section 18: AWS CloudFormation
            contentList.Add(new Content
            {
                contentName = "Section_18_AWS CloudFormation", // Managing your infrastructure as code
                startPage = 409,
                numberOfPage = 43
            });

            // Section 19: AWS Monitoring & Audit: CloudWatch, X-Ray and CloudTrail
            contentList.Add(new Content
            {
                contentName = "Section_19_AWS Monitoring, Troubleshooting & Audit", // CloudWatch, X-Ray and CloudTrail
                startPage = 452,
                numberOfPage = 48
            });

            // Section 20: AWS Integration & Messaging: SQS, SNS & Kinesis
            contentList.Add(new Content
            {
                contentName = "Section_20_AWS Integration & Messaging", // SQS, SNS & Kinesis
                startPage = 500,
                numberOfPage = 63
            });

            // Section 21: AWS Serverless: Lambda
            contentList.Add(new Content
            {
                contentName = "Section_21_AWS Lambda", // It’s a serverless world
                startPage = 563,
                numberOfPage = 61
            });

            // Section 22: AWS Serverless: DynamoDB
            contentList.Add(new Content
            {
                contentName = "Section_22_DynamoDB", // NoSQL Serverless Database
                startPage = 624,
                numberOfPage = 47
            });

            // Section 23: AWS Serverless: API Gateway
            contentList.Add(new Content
            {
                contentName = "Section_23_API Gateway", // Build, Deploy and Manage APIs
                startPage = 671,
                numberOfPage = 42
            });

            // Section 24: AWS Serverless: SAM - Serverless Application Model
            contentList.Add(new Content
            {
                contentName = "Section_24_AWS Serverless Application Model (SAM)", // Taking your Serverless Development to the next level
                startPage = 713,
                numberOfPage = 9
            });

            // Section 25: Cloud Devlopment Kit(CDK)
            contentList.Add(new Content
            {
                contentName = "Section_25_AWS Cloud Development Kit",
                startPage = 722,
                numberOfPage = 5
            });

            // Section 26: Cognito: Cognito User Pools, Cognito Identity Pools & Cognito Sync
            contentList.Add(new Content
            {
                contentName = "Section_26_Amazon Cognito Section",
                startPage = 727,
                numberOfPage = 17
            });

            // Section 27: Other Serverless: Step Functions & AppSync
            contentList.Add(new Content
            {
                contentName = "Section_27_Other Serverless Section",
                startPage = 744,
                numberOfPage = 19
            });

            // Section 28: Advanced Identity
            contentList.Add(new Content
            {
                contentName = "Section_28_Advanced Identity Section",
                startPage = 763,
                numberOfPage = 22
            });

            // Section 29: AWS Security & Encryption: KMS, Encryption SDK, SSM Parameter Store, IAM & STS
            contentList.Add(new Content
            {
                contentName = "Section_29_AWS Security & Encryption", // KMS, Encryption SDK, SSM Parameter Store
                startPage = 785,
                numberOfPage = 33
            });

            // Section 30: AWS Other Services
            contentList.Add(new Content
            {
                contentName = "Section_30_Other AWS Services", // Quick overview of other services that might have questions on at the exam
                startPage = 818,
                numberOfPage = 9
            });

            // Section 31: AWS Final Cleanup
            contentList.Add(new Content
            {
                contentName = "Section_31_Exam Review & Tips",
                startPage = 827,
                numberOfPage = 9
            });

            //// Section 32: Preparing for the Exam - AWS Certified Developer Associate
            //contentList.Add(new Content
            //{
            //    contentName = "Section_32_Congratulations & Next Steps!",
            //    startPage = 836,
            //    numberOfPage = 30
            //});

            // Section 33: Congratulations - AWS Certified Developer Associate
            contentList.Add(new Content
            {
                contentName = "Section_33_Congratulations & Next Steps!",
                startPage = 836,
                numberOfPage = 3
            });

            Program obj = new Program();
            foreach (var content in contentList)
            {
                obj.SplitAndSaveInterval(pdfFilePath, outputPath, content.startPage, content.numberOfPage, content.contentName);
                System.Console.WriteLine(content.contentName);
            }
            System.Console.WriteLine("Finished!");
            System.Console.ReadKey();
        }

        // v5.0.2
        private static void SplitPdfWithSpecificContentForSAA_C03_3()
        {
            string pdfFilePath = @"C:\Users\HumanR0006\sample.pdf";
            string outputPath = @"C:\Users\HumanR0006\PDF";
            List<Content> contentList = new List<Content>();
            // Section 3
            // Getting started with AWS
            contentList.Add(new Content
            {
                contentName = "Section_03_Getting started with AWS",
                startPage = 11,
                numberOfPage = 10
            });
            // Section 4
            // IAM & AWS CLI
            contentList.Add(new Content
            {
                contentName = "Section_04_IAM Section",
                startPage = 21,
                numberOfPage = 17
            });
            // Section 5
            // EC2 Fundamentals
            contentList.Add(new Content
            {
                contentName = "Section_05_EC2 Basics",
                startPage = 38,
                numberOfPage = 38
            });
            // Section 6
            // EC2 - Solutions Architect Associate Level
            contentList.Add(new Content
            {
                contentName = "Section_06_EC2 - Associate",
                startPage = 76,
                numberOfPage = 15
            });
            // Section 7
            // EC2 Instance Storage
            contentList.Add(new Content
            {
                contentName = "Section_07_EC2 Instance Storage Section",
                startPage = 91,
                numberOfPage = 25
            });
            // Section 8
            // High Availability and Scalability:ELB & ASG
            contentList.Add(new Content
            {
                contentName = "Section_08_ELB,ASG & EBS",// AWS Fundamentals – Part II
                                                         // Load Balancing, Auto Scaling Groups and EBS Volumes
                startPage = 116,
                numberOfPage = 42
            });
            // Section 9
            // AWS Fundamentals:RDS + Aurora + ElastiCache
            contentList.Add(new Content
            {
                contentName = "Section_09_RDS, Aurora & ElastiCache",
                startPage = 158,
                numberOfPage = 33
            });
            // Section 10
            // Route 53
            contentList.Add(new Content
            {
                contentName = "Section_10_Route 53 Section",
                startPage = 191,
                numberOfPage = 30
            });
            // Section 11
            // Classic Solutions Architecture Discussions
            contentList.Add(new Content
            {
                contentName = "Section_11_Classic Solutions Architecture",
                startPage = 221,
                numberOfPage = 39
            });
            // Section 12
            // Amazon S3 Introduction
            contentList.Add(new Content
            {
                contentName = "Section_12_Amazon S3 Section",
                startPage = 260,
                numberOfPage = 25
            });
            // Section 13
            // AWS SDK, IAM Roles & Policies
            contentList.Add(new Content
            {
                contentName = "Section_13_Developing on AWS",
                startPage = 285,
                numberOfPage = 4
            });
            // Section 14
            // Advanced Amazon S3
            contentList.Add(new Content
            {
                contentName = "Section_14_Advanced S3", // S3, Glacier, Athena
                startPage = 289,
                numberOfPage = 14
            });
            // Section 15
            // Amazon S3 Security
            contentList.Add(new Content
            {
                contentName = "Section_15_Amazon S3 Security",
                startPage = 303,
                numberOfPage = 20
            });
            // Section 16
            // CloudFront & AWS Global Accelerator
            contentList.Add(new Content
            {
                contentName = "Section_16_Global Infrastructure",
                startPage = 323,
                numberOfPage = 18
            });
            // Section 17
            // AWS Storage Extras
            contentList.Add(new Content
            {
                contentName = "Section_17_Advanced Storage on AWS",
                startPage = 341,
                numberOfPage = 34
            });
            // Section 18
            // Decoupling applications:SQS, SNS, Kinesis, Active MQ
            contentList.Add(new Content
            {
                contentName = "Section_18_AWS Integration & Messaging", // SQS, SNS & Kinesis
                startPage = 375,
                numberOfPage = 42
            });
            // Section 19
            // Containers on AWS: ECS, Fargate, ECR & EKS
            contentList.Add(new Content
            {
                contentName = "Section_19_Container Section",
                startPage = 417,
                numberOfPage = 24
            });
            // Section 20
            // Serverless Overviews from a Solution Architect Perspective
            contentList.Add(new Content
            {
                contentName = "Section_20_Serverless Overview",
                startPage = 441,
                numberOfPage = 39
            });
            // Section 21
            // Serverless Solution Architecture Discussions
            contentList.Add(new Content
            {
                contentName = "Section_21_Serverless Architectures",
                startPage = 480,
                numberOfPage = 22
            });
            // Section 22
            // Databases in AWS
            contentList.Add(new Content
            {
                contentName = "Section_22_Databases",
                startPage = 502,
                numberOfPage = 14
            });
            // Section 23
            // Data & Analytics
            contentList.Add(new Content
            {
                contentName = "Section_23_Data & Analytics",
                startPage = 516,
                numberOfPage = 35
            });
            // Section 24
            // Machine Learning
            contentList.Add(new Content
            {
                contentName = "Section_24_Machine Learning",
                startPage = 551,
                numberOfPage = 16
            });
            // Section 25
            // AWS Monitoring & Audit: CloudWatch, CloudTrail & Config
            contentList.Add(new Content
            {
                contentName = "Section_25_AWS Monitoring, Audit and Performance", // CloudWatch, CloudTrail & AWS Config
                startPage = 567,
                numberOfPage = 40
            });
            // Section 26
            // Identity and Access Management(IAM)-Advanced
            contentList.Add(new Content
            {
                contentName = "Section_26_Advanced Identity in AWS",
                startPage = 607,
                numberOfPage = 33
            });
            // Section 27
            // AWS Security & Encryption:KMS, SSM Parameter Store, CloudHSM, Shield, WAF
            contentList.Add(new Content
            {
                contentName = "Section_27_AWS Security & Encryption", // KMS, Encryption SDK, SSM Parameter Store
                startPage = 640,
                numberOfPage = 43
            });
            // Section 28
            // Networking - VPC
            contentList.Add(new Content
            {
                contentName = "Section_28_Virtual Private Cloud (VPC)",
                startPage = 683,
                numberOfPage = 76
            });
            // Section 29
            // Disaster Recovery & Migrations
            contentList.Add(new Content
            {
                contentName = "Section_29_Disaster Recovery & Migrations",
                startPage = 759,
                numberOfPage = 25
            });
            // Section 30
            // More Solution Architectures
            contentList.Add(new Content
            {
                contentName = "Section_30_Extra Solution Architecture discussions",
                startPage = 784,
                numberOfPage = 22
            });
            // Section 31
            // Other Services
            contentList.Add(new Content
            {
                contentName = "Section_31_Other Services", // Overview of Services that might come up in a few questions
                startPage = 806,
                numberOfPage = 22
            });
            // Section 32
            // WhitePapers and Architectures - AWS Certified Solutions Architest Associate
            contentList.Add(new Content
            {
                contentName = "Section_32_White Papers and Architectures", // Well Architected Framework, Disaster Recovery, etc…
                startPage = 828,
                numberOfPage = 8
            });
            // Section 33
            // Preparing for the Exam + Practice Exam - AWS Certified Solutions Architect Associate
            contentList.Add(new Content
            {
                contentName = "Section_33_Exam Review & Tips",
                startPage = 836,
                numberOfPage = 8
            });
            // Section 34
            // Congratulations - AWS Certified Solutions Architect Associate
            contentList.Add(new Content
            {
                contentName = "Section_34_Congratulations!",
                startPage = 844,
                numberOfPage = 2
            });

            Program obj = new Program();
            foreach (var content in contentList)
            {
                obj.SplitAndSaveInterval(pdfFilePath, outputPath, content.startPage, content.numberOfPage, content.contentName);
                System.Console.WriteLine(content.contentName);
            }
            System.Console.ReadKey();
        }

        // v5.0.2
        private static void SplitPdfWithSpecificContentForSAA_C03_2()
        {
            string pdfFilePath = @"C:\Users\HumanR0006\sample.pdf";
            string outputPath = @"C:\Users\HumanR0006\PDF";
            List<Content> contentList = new List<Content>();
            // Section 3
            // Getting started with AWS
            contentList.Add(new Content
            {
                contentName = "Section_03_Getting started with AWS",
                startPage = 11,
                numberOfPage = 10
            });
            // Section 4
            // IAM & AWS CLI
            contentList.Add(new Content
            {
                contentName = "Section_04_IAM",
                startPage = 21,
                numberOfPage = 17
            });
            // Section 5
            // EC2 Fundamentals
            contentList.Add(new Content
            {
                contentName = "Section_05_EC2 Basics",
                startPage = 38,
                numberOfPage = 38
            });
            // Section 6
            // EC2 - Solutions Architect Associate Level
            contentList.Add(new Content
            {
                contentName = "Section_06_EC2 – Associate",
                startPage = 76,
                numberOfPage = 15
            });
            // Section 7
            // EC2 Instance Storage
            contentList.Add(new Content
            {
                contentName = "Section_07_EC2 Instance Storage",
                startPage = 91,
                numberOfPage = 25
            });
            // Section 8
            // High Availability and Scalability:ELB & ASG
            contentList.Add(new Content
            {
                contentName = "Section_08_ELB,ASG & EBS",// AWS Fundamentals – Part II
                                                         // Load Balancing, Auto Scaling Groups and EBS Volumes
                startPage = 116,
                numberOfPage = 42
            });
            // Section 9
            // AWS Fundamentals:RDS + Aurora + ElastiCache
            contentList.Add(new Content
            {
                contentName = "Section_09_RDS, Aurora & ElastiCache",
                startPage = 158,
                numberOfPage = 33
            });
            // Section 10
            // Route 53
            contentList.Add(new Content
            {
                contentName = "Section_10_Route 53",
                startPage = 191,
                numberOfPage = 30
            });
            // Section 11
            // Classic Solutions Architecture Discussions
            contentList.Add(new Content
            {
                contentName = "Section_11_Classic Solutions Architecture",
                startPage = 221,
                numberOfPage = 39
            });
            // Section 12
            // Amazon S3 Introduction
            contentList.Add(new Content
            {
                contentName = "Section_12_S3 Storage and Data Management",
                startPage = 260,
                numberOfPage = 20
            });
            // Section 13
            // AWS SDK, IAM Roles & Policies
            contentList.Add(new Content
            {
                contentName = "Section_13_Developing on AWS",
                startPage = 280,
                numberOfPage = 4
            });
            // Section 14
            // Advanced Amazon S3
            contentList.Add(new Content
            {
                contentName = "Section_14_Advanced S3", // S3, Glacier, Athena
                startPage = 284,
                numberOfPage = 34
            });
            // Section 15
            // CloudFront & AWS Global Accelerator
            contentList.Add(new Content
            {
                contentName = "Section_15_Global Infrastructure",
                startPage = 318,
                numberOfPage = 18
            });
            // Section 16
            // AWS Storage Extras
            contentList.Add(new Content
            {
                contentName = "Section_16_Advanced Storage on AWS",
                startPage = 336,
                numberOfPage = 34
            });
            // Section 17
            // Decoupling applications:SQS, SNS, Kinesis, Active MQ
            contentList.Add(new Content
            {
                contentName = "Section_17_AWS Integration & Messaging", // SQS, SNS & Kinesis
                startPage = 370,
                numberOfPage = 41
            });
            // Section 18
            // Containers on AWS:ECS, Fargate, ECR & EKS
            contentList.Add(new Content
            {
                contentName = "Section_18_Container",
                startPage = 411,
                numberOfPage = 24
            });
            // Section 19
            // Serverless Overviews from a Solution Architect Perspective
            contentList.Add(new Content
            {
                contentName = "Section_19_Serverless Overview",
                startPage = 435,
                numberOfPage = 37
            });
            // Section 20
            // Serverless Solution Architecture Discussions
            contentList.Add(new Content
            {
                contentName = "Section_20_Serverless Architectures",
                startPage = 472,
                numberOfPage = 22
            });
            // Section 21
            // Databases in AWS
            contentList.Add(new Content
            {
                contentName = "Section_21_Databases",
                startPage = 494,
                numberOfPage = 14
            });
            // Section 22
            // Data & Analytics
            contentList.Add(new Content
            {
                contentName = "Section_22_Data & Analytics",
                startPage = 508,
                numberOfPage = 34
            });
            // Section 23
            // Machine Learning
            contentList.Add(new Content
            {
                contentName = "Section_23_Machine Learning",
                startPage = 542,
                numberOfPage = 16
            });
            // Section 24
            // AWS Monitoring & Audit:CloudWatch, CloudTrail & Config
            contentList.Add(new Content
            {
                contentName = "Section_24_AWS Monitoring, Audit and Performance", // CloudWatch, CloudTrail & AWS Config
                startPage = 558,
                numberOfPage = 39
            });
            // Section 25
            // Identity and Access Management(IAM)-Advanced
            contentList.Add(new Content
            {
                contentName = "Section_25_Advanced Identity in AWS",
                startPage = 597,
                numberOfPage = 26
            });
            // Section 26
            // AWS Security & Encryption:KMS, SSM Parameter Store, CloudHSM, Shield, WAF
            contentList.Add(new Content
            {
                contentName = "Section_26_AWS Security & Encryption", // KMS, Encryption SDK, SSM Parameter Store
                startPage = 623,
                numberOfPage = 42
            });
            // Section 27
            // Networking - VPC
            contentList.Add(new Content
            {
                contentName = "Section_27_Virtual Private Cloud (VPC)", 
                startPage = 665,
                numberOfPage = 76
            });
            // Section 28
            // Disaster Recovery & Migrations
            contentList.Add(new Content
            {
                contentName = "Section_28_Disaster Recovery & Migrations",
                startPage = 741,
                numberOfPage = 25
            });
            // Section 29
            // More Solution Architectures
            contentList.Add(new Content
            {
                contentName = "Section_29_Extra Solution Architecture discussions",
                startPage = 766,
                numberOfPage = 22
            });
            // Section 30
            // Other Services
            contentList.Add(new Content
            {
                contentName = "Section_30_Other Services", // Overview of Services that might come up in a few questions
                startPage = 788,
                numberOfPage = 13
            });
            // Section 31
            // WhitePapers and Architectures - AWS Certified Solutions Architest Associate
            contentList.Add(new Content
            {
                contentName = "Section_31_White Papers and Architectures", // Well Architected Framework, Disaster Recovery, etc…
                startPage = 801,
                numberOfPage = 8
            });
            // Section 32
            // Preparing for the Exam + Practice Exam - AWS Certified Solutions Architect Associate
            contentList.Add(new Content
            {
                contentName = "Section_32_Exam Review & Tips",
                startPage = 809,
                numberOfPage = 8
            });
            // Section 33
            // Congratulations - AWS Certified Solutions Architect Associate
            contentList.Add(new Content
            {
                contentName = "Section_33_Congratulations!",
                startPage = 817,
                numberOfPage = 2
            });

            Program obj = new Program();
            foreach (var content in contentList)
            {
                obj.SplitAndSaveInterval(pdfFilePath, outputPath, content.startPage, content.numberOfPage, content.contentName);
            }
        }

        // v4.9.3
        private static void SplitPdfWithSpecificContentForSAA_C03_1()
        {
            string pdfFilePath = @"C:\Users\HumanR0006\sample.pdf";
            string outputPath = @"C:\Users\HumanR0006\PDF";
            List<Content> contentList = new List<Content>();
            // Section 3
            // Getting started with AWS
            contentList.Add(new Content
            {
                contentName = "Section_03_Getting started with AWS",
                startPage = 11,
                numberOfPage = 10
            });
            // Section 4
            // IAM & AWS CLI
            contentList.Add(new Content
            {
                contentName = "Section_04_IAM & AWS CLI",
                startPage = 21,
                numberOfPage = 17
            });
            // Section 5
            // EC2 Fundamentals
            contentList.Add(new Content
            {
                contentName = "Section_05_EC2 Basics",
                startPage = 38,
                numberOfPage = 38
            });
            // Section 6
            // EC2 - Solutions Architect Associate Level
            contentList.Add(new Content
            {
                contentName = "Section_06_EC2 – Associate",
                startPage = 76,
                numberOfPage = 19
            });
            // Section 7
            // EC2 Instance Storage
            contentList.Add(new Content
            {
                contentName = "Section_07_EC2 Instance Storage",
                startPage = 95,
                numberOfPage = 25
            });
            // Section 8
            // High Availability and Scalability:ELB & ASG
            contentList.Add(new Content
            {
                contentName = "Section_08_ELB,ASG & EBS",// AWS Fundamentals – Part II
                                                         // Load Balancing, Auto Scaling Groups and EBS Volumes
                startPage = 120,
                numberOfPage = 45
            });
            // Section 9
            // AWS Fundamentals:RDS + Aurora + ElastiCache
            contentList.Add(new Content
            {
                contentName = "Section_09_RDS, Aurora & ElastiCache",
                startPage = 165,
                numberOfPage = 33
            });
            // Section 10
            // Route 53
            contentList.Add(new Content
            {
                contentName = "Section_10_Route 53",
                startPage = 198,
                numberOfPage = 31
            });
            // Section 11
            // Classic Solutions Architecture Discussions
            contentList.Add(new Content
            {
                contentName = "Section_11_Classic Solutions Architecture",
                startPage = 229,
                numberOfPage = 39
            });
            // Section 12
            // Amazon S3 Introduction
            contentList.Add(new Content
            {
                contentName = "Section_12_S3 Storage and Data Management",
                startPage = 268,
                numberOfPage = 21
            });
            // Section 13
            // AWS SDK, IAM Roles & Policies
            contentList.Add(new Content
            {
                contentName = "Section_13_Developing on AWS",
                startPage = 289,
                numberOfPage = 4
            });
            // Section 14
            // Advanced Amazon S3
            // Section 15
            // CloudFront & AWS Global Accelerator
            // Section 16
            // AWS Storage Extras
            contentList.Add(new Content
            {
                contentName = "Section_14_Advanced S3",
                startPage = 293,
                numberOfPage = 82
            });
            // Section 17
            // Decoupling applications:SQS, SNS, Kinesis, Active MQ
            contentList.Add(new Content
            {
                contentName = "Section_17_AWS Integration & Messaging", // SQS, SNS & Kinesis
                startPage = 375,
                numberOfPage = 46
            });
            // Section 18
            // Containers on AWS:ECS, Fargate, ECR & EKS
            contentList.Add(new Content
            {
                contentName = "Section_18_Container",
                startPage = 421,
                numberOfPage = 24
            });
            // Section 19
            // Serverless Overviews from a Solution Architect Perspective
            contentList.Add(new Content
            {
                contentName = "Section_19_Serverless Overview",
                startPage = 445,
                numberOfPage = 40
            });
            // Section 20
            // Serverless Solution Architecture Discussions
            contentList.Add(new Content
            {
                contentName = "Section_20_Serverless Architectures",
                startPage = 485,
                numberOfPage = 32
            });
            // Section 21
            // Databases in AWS
            // Section 22
            // Data & Analytics
            contentList.Add(new Content
            {
                contentName = "Section_21_Databases",
                startPage = 517,
                numberOfPage = 27
            });
            // Section 23
            // Machine Learning
            contentList.Add(new Content
            {
                contentName = "Section_23_Machine Learning",
                startPage = 750,
                numberOfPage = 13
            });
            // Section 24
            // AWS Monitoring & Audit:CloudWatch, CloudTrail & Config
            // Section 25
            // Identity and Access Management(IAM)-Advanced
            contentList.Add(new Content
            {
                contentName = "Section_24_AWS Monitoring, Audit and Performance", // CloudWatch, CloudTrail & AWS Config
                startPage = 544,
                numberOfPage = 69
            });
            // Section 26
            // AWS Security & Encryption:KMS, SSM Parameter Store, CloudHSM, Shield, WAF
            contentList.Add(new Content
            {
                contentName = "Section_26_AWS Security & Encryption", // KMS, Encryption SDK, SSM Parameter Store
                startPage = 613,
                numberOfPage = 38
            });
            // Section 27
            // Networking - VPC
            // Section 28
            // Disaster Recovery & Migrations
            contentList.Add(new Content
            {
                contentName = "Section_27_Virtual Private Cloud (VPC)",
                startPage = 651,
                numberOfPage = 99
            });
            // Section 29
            // More Solution Architectures
            contentList.Add(new Content
            {
                contentName = "Section_29_Extra Solution Architecture discussions",
                startPage = 763,
                numberOfPage = 20
            });
            // Section 30
            // Other Services
            contentList.Add(new Content
            {
                contentName = "Section_30_Other Services", // Overview of Services that might come up in a few questions
                startPage = 783,
                numberOfPage = 26
            });
            // Section 31
            // WhitePapers and Architectures - AWS Certified Solutions Architest Associate
            contentList.Add(new Content
            {
                contentName = "Section_31_White Papers and Architectures", // Well Architected Framework, Disaster Recovery, etc…
                startPage = 809,
                numberOfPage = 8
            });
            // Section 32
            // Preparing for the Exam + Practice Exam - AWS Certified Solutions Architect Associate
            contentList.Add(new Content
            {
                contentName = "Section_32_Exam Review & Tips",
                startPage = 817,
                numberOfPage = 8
            });
            // Section 33
            // Congratulations - AWS Certified Solutions Architect Associate
            contentList.Add(new Content
            {
                contentName = "Section_33_Congratulations!",
                startPage = 825,
                numberOfPage = 2
            });

            Program obj = new Program();
            foreach (var content in contentList)
            {
                obj.SplitAndSaveInterval(pdfFilePath, outputPath, content.startPage, content.numberOfPage, content.contentName);
            }
        }

        // v2.9
        private static void SplitPdfWithSpecificContentForCLF_C01()
        {
            string pdfFilePath = @"C:\Users\HumanR0006\sample.pdf";
            string outputPath = @"C:\Users\HumanR0006\PDF";
            List<Content> contentList = new List<Content>();
            // Section 3
            contentList.Add(new Content
            {
                contentName = "Section_03_What is Cloud Computing",
                startPage = 10,
                numberOfPage = 29
            });
            // Section 4
            contentList.Add(new Content
            {
                contentName = "Section_04_IAM - Identity and Access Management",
                startPage = 39,
                numberOfPage = 18
            });
            // Section 5
            contentList.Add(new Content
            {
                contentName = "Section_05_EC2 - Elastic Compute Cloud",
                startPage = 57,
                numberOfPage = 35
            });
            // Section 6
            contentList.Add(new Content
            {
                contentName = "Section_06_EC2 Instance Storage",
                startPage = 92,
                numberOfPage = 20
            });
            // Section 7
            contentList.Add(new Content
            {
                contentName = "Section_07_ELB & ASG - Elastic Load Balancing & Auto Scaling Groups",
                startPage = 112,
                numberOfPage = 16
            });
            // Section 8
            contentList.Add(new Content
            {
                contentName = "Section_08_S3",
                startPage = 128,
                numberOfPage = 43
            });
            // Section 9
            contentList.Add(new Content
            {
                contentName = "Section_09_Database & Analytics",
                startPage = 171,
                numberOfPage = 29
            });
            // Section 10
            contentList.Add(new Content
            {
                contentName = "Section_10_Other Compute Services_ECS,Lambda,Batch,Lightsail",
                startPage = 200,
                numberOfPage = 23
            });
            // Section 11
            contentList.Add(new Content
            {
                contentName = "Section_11_Deployments & Managing Infrastructure at Scale",
                startPage = 223,
                numberOfPage = 27
            });
            // Section 12
            contentList.Add(new Content
            {
                contentName = "Section_12_Leveraging the AWS Global Infrastructure",
                startPage = 250,
                numberOfPage = 26
            });
            // Section 13
            contentList.Add(new Content
            {
                contentName = "Section_13_Cloud Integrations",
                startPage = 276,
                numberOfPage = 12
            });
            // Section 14
            contentList.Add(new Content
            {
                contentName = "Section_14_Cloud Monitoring",
                startPage = 288,
                numberOfPage = 25
            });
            // Section 15
            contentList.Add(new Content
            {
                contentName = "Section_15_VPC & Networking",
                startPage = 313,
                numberOfPage = 18
            });
            // Section 16
            contentList.Add(new Content
            {
                contentName = "Section_16_Security & Compliance",
                startPage = 331,
                numberOfPage = 34
            });
            // Section 17
            contentList.Add(new Content
            {
                contentName = "Section_17_Machine Learning",
                startPage = 365,
                numberOfPage = 13
            });
            // Section 18
            contentList.Add(new Content
            {
                contentName = "Section_18_Account Management,Billing & Support",
                startPage = 378,
                numberOfPage = 48
            });
            // Section 19
            contentList.Add(new Content
            {
                contentName = "Section_19_Advanced Identity",
                startPage = 426,
                numberOfPage = 8
            });
            // Section 20
            contentList.Add(new Content
            {
                contentName = "Section_20_Other Services",
                startPage = 434,
                numberOfPage = 25
            });
            // Section 21
            contentList.Add(new Content
            {
                contentName = "Section_21_AWS Architecting & Ecosystem",
                startPage = 459,
                numberOfPage = 24
            });
            // Section 22
            contentList.Add(new Content
            {
                contentName = "Section_22_Exam Preparation",
                startPage = 483,
                numberOfPage = 9
            });
            // Section 23
            contentList.Add(new Content
            {
                contentName = "Section_23_Congratulation",
                startPage = 492,
                numberOfPage = 3
            });

            Program obj = new Program();
            foreach (var content in contentList)
            {
                obj.SplitAndSaveInterval(pdfFilePath, outputPath, content.startPage, content.numberOfPage, content.contentName);
            }
        }

        private static void SplitPdf()
        {
            string pdfFilePath = @"C:\PdfFiles\sample.pdf";
            string outputPath = @"C:\SplitedPdfFiles";
            int interval = 10;
            int pageNameSuffix = 0;

            // Intialize a new PdfReader instance with the contents of the source Pdf file:
            PdfReader reader = new PdfReader(pdfFilePath);

            FileInfo file = new FileInfo(pdfFilePath);
            string pdfFileName = file.Name.Substring(0, file.Name.LastIndexOf(".")) + "-";

            Program obj = new Program();

            for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber += interval)
            {
                pageNameSuffix++;
                string newPdfFileName = string.Format(pdfFileName + "{0}", pageNameSuffix);
                obj.SplitAndSaveInterval(pdfFilePath, outputPath, pageNumber, interval, newPdfFileName);
            }
        }

        private void SplitAndSaveInterval(string pdfFilePath, string outputPath, int startPage, int interval, string pdfFileName)
        {          
            using (PdfReader reader = new PdfReader(pdfFilePath))
            {
                Document document = new Document();
                PdfCopy copy = new PdfCopy(document, new FileStream(outputPath + "\\" + pdfFileName + ".pdf", FileMode.Create));
                document.Open();

                for (int pagenumber = startPage; pagenumber < (startPage + interval); pagenumber++)
                {
                    if (reader.NumberOfPages >= pagenumber)
                    {
                        copy.AddPage(copy.GetImportedPage(reader, pagenumber));
                    }
                    else
                    {
                        break;
                    }

                }

                document.Close();
            }
        }
    }

    class Content
    {
        public string contentName { get; set; }
        public int startPage { get; set; }
        public int numberOfPage { get; set; }
    }
}
 