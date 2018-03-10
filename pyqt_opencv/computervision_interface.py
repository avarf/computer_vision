#!/usr/bin/python3

import os
import sys
from PyQt5.QtWidgets import (QVBoxLayout, QLabel, QMainWindow, QWidget, QToolTip, QPushButton, QApplication)
from PyQt5.QtGui import (QImage, QPixmap, QFont)
from PyQt5.QtCore import (QObject, pyqtSignal, pyqtSlot, QThread)

from PyQt5.uic import loadUi

import PyQt5.QtCore

import cv2

class OCV_Class(QThread):
    """OCV_Class is for the opencv part of the interface"""

    changePixmap = pyqtSignal(QPixmap)

    def __init__(self, device_id=0, parent=None):
        QThread.__init__(self, parent)
        self.videocap = cv2.VideoCapture(device_id)

    def run(self):
        while True:
            ret, frame = self.videocap.read()
            qt_img = self.convert_to_qtformat(frame)
            self.changePixmap.emit(qt_img)

    def convert_to_qtformat(self, frame):
        rgb_image = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
        convertToQtFormat = QImage(rgb_image.data, rgb_image.shape[1], rgb_image.shape[0], QImage.Format_RGB888)
        convertToQtFormat = QPixmap.fromImage(convertToQtFormat)
        p = convertToQtFormat.scaled(640, 480, PyQt5.QtCore.Qt.KeepAspectRatio)
        return p

        

class PQTInterface(QWidget):
    """docstring for PQTInterface"""
    def __init__(self):
        super(PQTInterface, self).__init__()
        self.initUI()

    def initUI(self):

        self.ocv = OCV_Class()
        # self.thread = QThread()

        self.video_placeholder = QLabel(self)

        start_btn = QPushButton('Start', self)
        start_btn.clicked.connect(self._start_video_play)

        # If we click on the button, the signal clicked is emitted. The slot can be a Qt slot or any Python callable.
        qbtn = QPushButton('Quit', self)
        qbtn.clicked.connect(QApplication.instance().quit)
        qbtn.resize(qbtn.sizeHint())

        page_layout = QVBoxLayout()
        page_layout.addWidget(self.video_placeholder)
        page_layout.addWidget(start_btn)
        page_layout.addWidget(qbtn)

        self.setLayout(page_layout)
        self.setGeometry(20, 150, 500, 500)
        self.setWindowTitle('simple window')
        self.show()

    def _start_video_play(self):
        # print('in _start_video_play - ui class- before connect')

        self.ocv.changePixmap.connect(self.video_placeholder.setPixmap)
        self.ocv.start()

































if __name__ == '__main__':

    # Every PyQt5 application must create an application object
    app = QApplication(sys.argv)

    ui = PQTInterface()


    sys.exit(app.exec_())