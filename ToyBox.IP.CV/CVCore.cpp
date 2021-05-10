#include "pch.h"
#include "CVCore.h"

using namespace cv;

CV::CVCore::CVCore()
{
}

CVData CV::CVCore::Inquire(CVData type)
{
	return 0;
}

CVData CV::CVCore::Commend(CVData type, const char* args, CVData id)
{
	try
	{
		switch (type)
		{
		case 0:
		{
			Mat* image = static_cast<Mat*>(AdressVector[id]);
			imshow(string(args), *image);
			waitKey(1);
			break;
		}
		case 1:
		{
			Mat image = imread(std::string(args), cv::ImreadModes::IMREAD_GRAYSCALE);
			AdressVector.push_back(new Mat(image));
			return AdressVector.size() - 1;
			break;
		}
		case 2:
		{
			FFT(id);
			/*
			auto ptr = AdressVector[id];
			Mat* image = static_cast<Mat*>(AdressVector[id]);
			Mat* imageResult = new Mat();
			image->convertTo(*imageResult, CV_32F)
				dft(*imageResult, *imageResult, DftFlags::DCT_INVERSE);
			AdressVector.push_back(imageResult);
			return AdressVector.size() - 1;
			*/
			break;
		}
		default:
		{
			break;
		}
		}
	}
	catch (cv::Exception& e)
	{
		throw e;
	}
	return 0;
}

CVData CV::CVCore::FFT(CVData id)
{
	// Read image from file
	// Make sure that the image is in grayscale
	Mat* img = static_cast<Mat*>(AdressVector[id]);

	Mat planes[] = { Mat_<float>(*img), Mat::zeros(img->size(), CV_32F) };
	Mat complexI;    //Complex plane to contain the DFT coefficients {[0]-Real,[1]-Img}
	merge(planes, 2, complexI);
	dft(complexI, complexI);  // Applying DFT
	Mat complexVector[] = { Mat::zeros(img->size(), CV_32F),Mat::zeros(img->size(), CV_32F) };
	split(complexI, complexVector);
	normalize(complexVector[0], complexVector[0], 255);
	normalize(complexVector[1], complexVector[1], 255);
	//divide(255.0, complexVector[1], complexVector[1]);
	imshow("DFT-R", complexVector[0]);
	imshow("DFT-I", complexVector[1]);
	Mat sum = complexVector[0] + complexVector[1];
	imshow("DFT-RI", sum);

	// Reconstructing original imae from the DFT coefficients
	Mat invDFT, invDFTcvt;
	idft(complexI, invDFT, DFT_SCALE | DFT_REAL_OUTPUT); // Applying IDFT
	invDFT.convertTo(invDFTcvt, CV_8U);
	imshow("Output", invDFTcvt);

	//show the image
	imshow("Original Image", *img);

	// Wait until user press some key
	waitKey(0);
	return 0;
}

CV::CVCore::~CVCore()
{
}