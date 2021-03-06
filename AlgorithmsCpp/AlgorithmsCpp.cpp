#include "stdafx.h"

#include <Windows.h>

#include "opencv2/opencv.hpp"
#include "opencv2/highgui/highgui.hpp"
#include "opencv2/imgproc.hpp"


using namespace cv;
using namespace std;

#define DllExport extern "C" __declspec(dllexport)

struct ImageInfo
{
	unsigned char *data;
	int size;
};

//release memory
DllExport bool ReleaseMemoryFromC(unsigned char* buf)
{
	if (buf == NULL)
		return false;

	free(buf);
	return true;
}

DllExport void convertToGray(unsigned char* data, int dataLen, ImageInfo & imInfo)
{
	vector<unsigned char> inputImageBytes(data, data + dataLen);
	Mat image = imdecode(inputImageBytes, CV_LOAD_IMAGE_COLOR);
	Mat processed;
	cvtColor(image, processed, CV_BGR2GRAY);
	vector<unsigned char> bytes;
	imencode(".png", processed, bytes);

	imInfo.size = bytes.size();
	imInfo.data = (unsigned char *)calloc(imInfo.size, sizeof(unsigned char));
	std::copy(bytes.begin(), bytes.end(), imInfo.data);
}

DllExport void firstAproximation(int* p1, int* p2, double &pan, double &tilt)
{
	pan = p1[0]*0.1+p1[1]*0.1;
	tilt = p2[0]*0.1+p2[1]*0.1;
	//TODO
}

DllExport void finalPTZParams(unsigned char* dataR, int dataRLen, unsigned char* dataP, int dataPLen, double &pan, double &tilt, int &zoom)
{
	vector<unsigned char> imgBytesR(dataR, dataR + dataRLen);
	Mat imR = imdecode(imgBytesR, CV_LOAD_IMAGE_COLOR);
	vector<unsigned char> imgBytesP(dataP, dataP + dataPLen);
	Mat imP = imdecode(imgBytesP, CV_LOAD_IMAGE_COLOR);
	
	pan = 0.01;
	tilt = 0.02;
	zoom = 123;
	//TODO
}