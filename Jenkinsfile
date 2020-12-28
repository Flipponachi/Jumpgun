pipeline{
    agent any

    stages{
        stage('Cloning'){
            steps{
                echo 'Cloning...'
            }
        }
        stage('Build'){
           steps{
                echo 'Building'
           }
        }
        stage('Test'){
            steps{
                echo 'Testing'
            }        
        }
        stage('Docker Actions'){
            steps{
                echo 'Docker Building ${BUILD.ID}'
            }
           
        }
       
        
    }
}