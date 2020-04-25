provider "aws" {
  region="us-east-1"
  
}

resource "aws_instance" "WebInstance" {
  ami = "ami-0f7122ac3de6f22b2"
  instance_type = "t2.micro"

  tags = {
    Name = "Tag:WebInstance"
  }
}
